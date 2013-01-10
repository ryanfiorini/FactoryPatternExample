namespace FactoryPatternExample
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
            this.btnCreateComputer = new System.Windows.Forms.Button();
            this.rdoGeneric = new System.Windows.Forms.RadioButton();
            this.rdoBrandX = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCreateComputer
            // 
            this.btnCreateComputer.Location = new System.Drawing.Point(31, 52);
            this.btnCreateComputer.Name = "btnCreateComputer";
            this.btnCreateComputer.Size = new System.Drawing.Size(150, 23);
            this.btnCreateComputer.TabIndex = 0;
            this.btnCreateComputer.Text = "Create Computer";
            this.btnCreateComputer.UseVisualStyleBackColor = true;
            this.btnCreateComputer.Click += new System.EventHandler(this.btnCreateComputer_Click);
            // 
            // rdoGeneric
            // 
            this.rdoGeneric.AutoSize = true;
            this.rdoGeneric.Checked = true;
            this.rdoGeneric.Location = new System.Drawing.Point(31, 13);
            this.rdoGeneric.Name = "rdoGeneric";
            this.rdoGeneric.Size = new System.Drawing.Size(62, 17);
            this.rdoGeneric.TabIndex = 1;
            this.rdoGeneric.TabStop = true;
            this.rdoGeneric.Text = "Generic";
            this.rdoGeneric.UseVisualStyleBackColor = true;
            // 
            // rdoBrandX
            // 
            this.rdoBrandX.AutoSize = true;
            this.rdoBrandX.Location = new System.Drawing.Point(99, 12);
            this.rdoBrandX.Name = "rdoBrandX";
            this.rdoBrandX.Size = new System.Drawing.Size(60, 17);
            this.rdoBrandX.TabIndex = 2;
            this.rdoBrandX.Text = "BrandX";
            this.rdoBrandX.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rdoBrandX);
            this.Controls.Add(this.rdoGeneric);
            this.Controls.Add(this.btnCreateComputer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateComputer;
        private System.Windows.Forms.RadioButton rdoGeneric;
        private System.Windows.Forms.RadioButton rdoBrandX;
    }
}

