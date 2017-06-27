namespace ChangeComponentMaterial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnA992 = new System.Windows.Forms.Button();
            this.btnA572 = new System.Windows.Forms.Button();
            this.btnA36 = new System.Windows.Forms.Button();
            this.btnA53B = new System.Windows.Forms.Button();
            this.btnA514 = new System.Windows.Forms.Button();
            this.btnNOMASS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnA992
            // 
            this.btnA992.Location = new System.Drawing.Point(12, 12);
            this.btnA992.Name = "btnA992";
            this.btnA992.Size = new System.Drawing.Size(260, 30);
            this.btnA992.TabIndex = 0;
            this.btnA992.Text = "A992";
            this.btnA992.UseVisualStyleBackColor = true;
            this.btnA992.Click += new System.EventHandler(this.btnA992_Click);
            // 
            // btnA572
            // 
            this.btnA572.Location = new System.Drawing.Point(12, 47);
            this.btnA572.Name = "btnA572";
            this.btnA572.Size = new System.Drawing.Size(260, 30);
            this.btnA572.TabIndex = 1;
            this.btnA572.Text = "A572-50";
            this.btnA572.UseVisualStyleBackColor = true;
            this.btnA572.Click += new System.EventHandler(this.btnA572_Click);
            // 
            // btnA36
            // 
            this.btnA36.Location = new System.Drawing.Point(12, 83);
            this.btnA36.Name = "btnA36";
            this.btnA36.Size = new System.Drawing.Size(260, 30);
            this.btnA36.TabIndex = 2;
            this.btnA36.Text = "A36";
            this.btnA36.UseVisualStyleBackColor = true;
            this.btnA36.Click += new System.EventHandler(this.btnA36_Click);
            // 
            // btnA53B
            // 
            this.btnA53B.Location = new System.Drawing.Point(12, 119);
            this.btnA53B.Name = "btnA53B";
            this.btnA53B.Size = new System.Drawing.Size(260, 30);
            this.btnA53B.TabIndex = 3;
            this.btnA53B.Text = "A53 Gr. B";
            this.btnA53B.UseVisualStyleBackColor = true;
            this.btnA53B.Click += new System.EventHandler(this.btnA53B_Click);
            // 
            // btnA514
            // 
            this.btnA514.Location = new System.Drawing.Point(12, 155);
            this.btnA514.Name = "btnA514";
            this.btnA514.Size = new System.Drawing.Size(260, 30);
            this.btnA514.TabIndex = 4;
            this.btnA514.Text = "A514";
            this.btnA514.UseVisualStyleBackColor = true;
            this.btnA514.Click += new System.EventHandler(this.btnA514_Click);
            // 
            // btnNOMASS
            // 
            this.btnNOMASS.Location = new System.Drawing.Point(12, 191);
            this.btnNOMASS.Name = "btnNOMASS";
            this.btnNOMASS.Size = new System.Drawing.Size(260, 30);
            this.btnNOMASS.TabIndex = 5;
            this.btnNOMASS.Text = "NO MASS";
            this.btnNOMASS.UseVisualStyleBackColor = true;
            this.btnNOMASS.Click += new System.EventHandler(this.btnNOMASS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 235);
            this.Controls.Add(this.btnNOMASS);
            this.Controls.Add(this.btnA514);
            this.Controls.Add(this.btnA53B);
            this.Controls.Add(this.btnA36);
            this.Controls.Add(this.btnA572);
            this.Controls.Add(this.btnA992);
            this.Name = "Form1";
            this.Text = "Change Material To:";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnA992;
        private System.Windows.Forms.Button btnA572;
        private System.Windows.Forms.Button btnA36;
        private System.Windows.Forms.Button btnA53B;
        private System.Windows.Forms.Button btnA514;
        private System.Windows.Forms.Button btnNOMASS;
    }
}

