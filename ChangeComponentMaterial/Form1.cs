using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Inventor;

namespace ChangeComponentMaterial
{
    public partial class Form1 : Form
    {
        Inventor.Application _invApp;
        bool _started;
        AssemblyDocument _asmDoc;

        public Form1()
        {
            InitializeComponent();

            try
            {
                _invApp = (Inventor.Application)Marshal.GetActiveObject("Inventor.Application");

            }
            catch (Exception ex)
            {
                try
                {
                    Type invAppType = Type.GetTypeFromProgID("Inventor.Application");

                    _invApp = (Inventor.Application)System.Activator.CreateInstance(invAppType);
                    _invApp.Visible = true;

                    //Note: if the Inventor session is left running after this
                    //form is closed, there will still an be and Inventor.exe 
                    //running. We will use this Boolean to test in Form1.Designer.cs 
                    //in the dispose method whether or not the Inventor App should
                    //be shut down when the form is closed.
                    _started = true;

                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.ToString());
                    MessageBox.Show("Unable to get or start Inventor");
                }
            }
        }

        private void btnA992_Click(object sender, EventArgs e)
        {
            Check();
            SetMaterial("Steel ASTM A992");
            _invApp.ActiveView.Update();
        }

        private void btnA572_Click(object sender, EventArgs e)
        {
            Check();
            SetMaterial("Steel ASTM A572-50");
            _invApp.ActiveView.Update();
        }

        private void btnA36_Click(object sender, EventArgs e)
        {
            Check();
            SetMaterial("Steel ASTM A36");
            _invApp.ActiveView.Update();
        }

        private void btnA53B_Click(object sender, EventArgs e)
        {
            Check();
            SetMaterial("Steel ASTM A53 Gr. B");
            _invApp.ActiveView.Update();
        }

        private void btnA514_Click(object sender, EventArgs e)
        {
            Check();
            SetMaterial("Steel ASTM A514");
            _invApp.ActiveView.Update();
        }

        private void btnNOMASS_Click(object sender, EventArgs e)
        {
            Check();
            SetMaterial("NO MASS");
            _invApp.ActiveView.Update();
        }

        private void Check()
        {
            if (_invApp.Documents.Count == 0)
            {
                MessageBox.Show("Need to open an Assembly document");
                return;
            }

            if (_invApp.ActiveDocument.DocumentType != DocumentTypeEnum.kAssemblyDocumentObject)
            {
                MessageBox.Show("Need to have an Assembly document active");
                return;
            }

            _asmDoc = default(AssemblyDocument);
            _asmDoc = (AssemblyDocument)_invApp.ActiveDocument;

            if (_asmDoc.SelectSet.Count == 0)
            {
                MessageBox.Show("Need to select a Part or Sub Assembly");
                return;
            }
        }

        private void SetMaterial(string materialName)
        {
            SelectSet selSet = default(SelectSet);
            selSet = _asmDoc.SelectSet;

            try
            {
                ComponentOccurrence compOcc = default(ComponentOccurrence);
                object obj = null;
                foreach (object obj_loopVariable in selSet)
                {
                    obj = obj_loopVariable;
                    compOcc = (ComponentOccurrence)obj;
                    Asset localAsset;
                    PartDocument partDoc;
                    if (compOcc.DefinitionDocumentType == Inventor.DocumentTypeEnum.kPartDocumentObject)
                    {
                        partDoc = compOcc.Definition.Document;
                        try
                        {
                            localAsset = partDoc.Assets[materialName];
                        }
                        //failed to load the material so import it
                        catch (Exception ex)
                        {
                            AssetLibrary assetLib = _invApp.AssetLibraries["PattersonMaterialLibrary"];

                            Asset libAsset = assetLib.MaterialAssets[materialName];
                            localAsset = libAsset.CopyTo(partDoc);
                        }
                        partDoc.ActiveMaterial = localAsset;
                        DeleteUnusedMaterials(ref partDoc);
                        ClearMaterialOverrides(ref partDoc);
                        partDoc.Save();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Is the selected item a Component?");
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void DeleteUnusedMaterials(ref PartDocument partDoc)
        {
            foreach (MaterialAsset matAsset in partDoc.MaterialAssets)
            {
                if (!matAsset.IsUsed)
                    matAsset.Delete();
            }
        }

        private void ClearMaterialOverrides(ref PartDocument partDoc)
        {
            partDoc.AppearanceSourceType = AppearanceSourceTypeEnum.kMaterialAppearance;

            //if the part is a derived part...
            if (partDoc.ComponentDefinition.ReferenceComponents.DerivedPartComponents.Count != 0)
            {
                DerivedPartComponent derivedPartComp;
                derivedPartComp = partDoc.ComponentDefinition.ReferenceComponents.DerivedPartComponents[1];
                derivedPartComp.Definition.UseColorOverridesFromSource = true;
                derivedPartComp.Definition = derivedPartComp.Definition;
            }
        }
    }
}
