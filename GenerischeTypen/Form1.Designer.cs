namespace GenerischeTypen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListString = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.btnListLand = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListString
            // 
            this.btnListString.Location = new System.Drawing.Point(12, 12);
            this.btnListString.Name = "btnListString";
            this.btnListString.Size = new System.Drawing.Size(75, 23);
            this.btnListString.TabIndex = 0;
            this.btnListString.Text = "List String";
            this.btnListString.UseVisualStyleBackColor = true;
            this.btnListString.Click += new System.EventHandler(this.btnListString_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.Location = new System.Drawing.Point(408, 12);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(143, 23);
            this.btnDictionary.TabIndex = 1;
            this.btnDictionary.Text = "Dictionary String Land";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // btnListLand
            // 
            this.btnListLand.Location = new System.Drawing.Point(208, 12);
            this.btnListLand.Name = "btnListLand";
            this.btnListLand.Size = new System.Drawing.Size(75, 23);
            this.btnListLand.TabIndex = 2;
            this.btnListLand.Text = "List Land";
            this.btnListLand.UseVisualStyleBackColor = true;
            this.btnListLand.Click += new System.EventHandler(this.btnListLand_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 15;
            this.lstOutput.Location = new System.Drawing.Point(12, 41);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(539, 169);
            this.lstOutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 217);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnListLand);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnListString);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnListString;
        private Button btnDictionary;
        private Button btnListLand;
        private ListBox lstOutput;
    }
}