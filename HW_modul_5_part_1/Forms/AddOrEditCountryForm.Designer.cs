namespace HW_modul_5_part_1.Forms
{
    partial class AddOrEditCountryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.partOfWorldComboBox = new System.Windows.Forms.ComboBox();
            this.numericArea = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericArea)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название страны";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Площадь страны";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Часть мира";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(162, 15);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(180, 23);
            this.txtCountryName.TabIndex = 3;
            // 
            // partOfWorldComboBox
            // 
            this.partOfWorldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partOfWorldComboBox.FormattingEnabled = true;
            this.partOfWorldComboBox.Location = new System.Drawing.Point(162, 73);
            this.partOfWorldComboBox.Name = "partOfWorldComboBox";
            this.partOfWorldComboBox.Size = new System.Drawing.Size(180, 23);
            this.partOfWorldComboBox.TabIndex = 5;
            // 
            // numericArea
            // 
            this.numericArea.Location = new System.Drawing.Point(162, 44);
            this.numericArea.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericArea.Name = "numericArea";
            this.numericArea.Size = new System.Drawing.Size(180, 23);
            this.numericArea.TabIndex = 6;
            // 
            // AddOrEditCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 267);
            this.Controls.Add(this.numericArea);
            this.Controls.Add(this.partOfWorldComboBox);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOrEditCountryForm";
            this.Text = "AddOrEditCountryForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCountryName;
        private ComboBox partOfWorldComboBox;
        private NumericUpDown numericArea;
    }
}