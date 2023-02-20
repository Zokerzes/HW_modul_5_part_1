namespace HW_modul_5_part_1.Forms
{
    partial class AddOrEditCities
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.nameCityTxt = new System.Windows.Forms.TextBox();
            this.populationNumeric = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.IsCapitalCheckBox1 = new System.Windows.Forms.CheckBox();
            this.countryError = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.isCapitalError = new System.Windows.Forms.ErrorProvider(this.components);
            this.populationError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.populationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isCapitalError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название города";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Колличество населения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Страна";
            // 
            // countryComboBox
            // 
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(165, 10);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(153, 23);
            this.countryComboBox.TabIndex = 4;
            // 
            // nameCityTxt
            // 
            this.nameCityTxt.Location = new System.Drawing.Point(165, 39);
            this.nameCityTxt.Name = "nameCityTxt";
            this.nameCityTxt.Size = new System.Drawing.Size(153, 23);
            this.nameCityTxt.TabIndex = 5;
            // 
            // populationNumeric
            // 
            this.populationNumeric.Location = new System.Drawing.Point(163, 100);
            this.populationNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.populationNumeric.Name = "populationNumeric";
            this.populationNumeric.Size = new System.Drawing.Size(155, 23);
            this.populationNumeric.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(164, 144);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(245, 144);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // IsCapitalCheckBox1
            // 
            this.IsCapitalCheckBox1.AutoSize = true;
            this.IsCapitalCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsCapitalCheckBox1.Location = new System.Drawing.Point(12, 68);
            this.IsCapitalCheckBox1.Name = "IsCapitalCheckBox1";
            this.IsCapitalCheckBox1.Size = new System.Drawing.Size(169, 19);
            this.IsCapitalCheckBox1.TabIndex = 10;
            this.IsCapitalCheckBox1.Text = "Является столицей             ";
            this.IsCapitalCheckBox1.UseVisualStyleBackColor = true;
            // 
            // countryError
            // 
            this.countryError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.countryError.ContainerControl = this;
            // 
            // nameError
            // 
            this.nameError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.nameError.ContainerControl = this;
            // 
            // isCapitalError
            // 
            this.isCapitalError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.isCapitalError.ContainerControl = this;
            // 
            // populationError
            // 
            this.populationError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.populationError.ContainerControl = this;
            // 
            // AddOrEditCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 182);
            this.Controls.Add(this.IsCapitalCheckBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.populationNumeric);
            this.Controls.Add(this.nameCityTxt);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOrEditCities";
            this.Text = "Добавление города";
            ((System.ComponentModel.ISupportInitialize)(this.populationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isCapitalError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private ComboBox countryComboBox;
        private TextBox nameCityTxt;
        private NumericUpDown populationNumeric;
        private Button btnOK;
        private Button btnCancel;
        private CheckBox IsCapitalCheckBox1;
        private ErrorProvider countryError;
        private ErrorProvider nameError;
        private ErrorProvider isCapitalError;
        private ErrorProvider populationError;
    }
}