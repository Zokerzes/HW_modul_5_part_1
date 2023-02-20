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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.partOfWorldComboBox = new System.Windows.Forms.ComboBox();
            this.numericArea = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.areaError = new System.Windows.Forms.ErrorProvider(this.components);
            this.partOfWorldError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partOfWorldError)).BeginInit();
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
            this.txtCountryName.Validating += new System.ComponentModel.CancelEventHandler(this.txtCountryName_Validating);
            // 
            // partOfWorldComboBox
            // 
            this.partOfWorldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partOfWorldComboBox.FormattingEnabled = true;
            this.partOfWorldComboBox.Location = new System.Drawing.Point(162, 73);
            this.partOfWorldComboBox.Name = "partOfWorldComboBox";
            this.partOfWorldComboBox.Size = new System.Drawing.Size(180, 23);
            this.partOfWorldComboBox.TabIndex = 5;
            this.partOfWorldComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.partOfWorldComboBox_Validating);
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
            this.numericArea.Validating += new System.ComponentModel.CancelEventHandler(this.numericArea_Validating);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(162, 116);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(267, 116);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // nameError
            // 
            this.nameError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.nameError.ContainerControl = this;
            // 
            // areaError
            // 
            this.areaError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.areaError.ContainerControl = this;
            // 
            // partOfWorldError
            // 
            this.partOfWorldError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.partOfWorldError.ContainerControl = this;
            // 
            // AddOrEditCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 150);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numericArea);
            this.Controls.Add(this.partOfWorldComboBox);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOrEditCountryForm";
            this.Text = "AddOrEditCountryForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partOfWorldError)).EndInit();
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
        private Button btnOk;
        private Button btnCancel;
        private ErrorProvider nameError;
        private ErrorProvider areaError;
        private ErrorProvider partOfWorldError;
    }
}