namespace CalculatorApp
{
    partial class FormHasilPerhitungan
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
            this.groupBoxHasil = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.groupBoxHasil.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHasil
            // 
            this.groupBoxHasil.Controls.Add(this.listBox);
            this.groupBoxHasil.Location = new System.Drawing.Point(8, 7);
            this.groupBoxHasil.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxHasil.Name = "groupBoxHasil";
            this.groupBoxHasil.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxHasil.Size = new System.Drawing.Size(388, 224);
            this.groupBoxHasil.TabIndex = 0;
            this.groupBoxHasil.TabStop = false;
            this.groupBoxHasil.Text = "[ Hasil ]";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(4, 18);
            this.listBox.Margin = new System.Windows.Forms.Padding(2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(381, 199);
            this.listBox.TabIndex = 0;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(13, 235);
            this.btnHitung.Margin = new System.Windows.Forms.Padding(2);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(384, 20);
            this.btnHitung.TabIndex = 1;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormHasilPerhitungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 263);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.groupBoxHasil);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHasilPerhitungan";
            this.Text = "Hasil Perhitungan";
            this.groupBoxHasil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxHasil;
        private ListBox listBox;
        private Button btnHitung;
    }
}