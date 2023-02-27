namespace HW_modul_5_part_1
{
    partial class MainForm
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.CountryTabs = new System.Windows.Forms.TabPage();
            this.numeriCountryArea = new System.Windows.Forms.NumericUpDown();
            this.btnCountryAreaMore = new System.Windows.Forms.Button();
            this.btnGetEuropianCountry = new System.Windows.Forms.Button();
            this.btnUpdCountry = new System.Windows.Forms.Button();
            this.btnDeleteCountry = new System.Windows.Forms.Button();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.countryDataGrid = new System.Windows.Forms.DataGridView();
            this.CityTabs = new System.Windows.Forms.TabPage();
            this.btnCapitalMore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCountrySelected = new System.Windows.Forms.ComboBox();
            this.btnUpdCity = new System.Windows.Forms.Button();
            this.btnDeleteCity = new System.Windows.Forms.Button();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.сitiesDataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.CountryTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeriCountryArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataGrid)).BeginInit();
            this.CityTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сitiesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.CountryTabs);
            this.mainTabControl.Controls.Add(this.CityTabs);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(776, 426);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // CountryTabs
            // 
            this.CountryTabs.Controls.Add(this.numeriCountryArea);
            this.CountryTabs.Controls.Add(this.btnCountryAreaMore);
            this.CountryTabs.Controls.Add(this.btnGetEuropianCountry);
            this.CountryTabs.Controls.Add(this.btnUpdCountry);
            this.CountryTabs.Controls.Add(this.btnDeleteCountry);
            this.CountryTabs.Controls.Add(this.btnAddCountry);
            this.CountryTabs.Controls.Add(this.countryDataGrid);
            this.CountryTabs.Location = new System.Drawing.Point(4, 24);
            this.CountryTabs.Name = "CountryTabs";
            this.CountryTabs.Padding = new System.Windows.Forms.Padding(3);
            this.CountryTabs.Size = new System.Drawing.Size(768, 398);
            this.CountryTabs.TabIndex = 0;
            this.CountryTabs.Text = "Страны";
            this.CountryTabs.UseVisualStyleBackColor = true;
            // 
            // numeriCountryArea
            // 
            this.numeriCountryArea.Location = new System.Drawing.Point(662, 254);
            this.numeriCountryArea.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numeriCountryArea.Name = "numeriCountryArea";
            this.numeriCountryArea.Size = new System.Drawing.Size(107, 23);
            this.numeriCountryArea.TabIndex = 12;
            // 
            // btnCountryAreaMore
            // 
            this.btnCountryAreaMore.Location = new System.Drawing.Point(503, 235);
            this.btnCountryAreaMore.Name = "btnCountryAreaMore";
            this.btnCountryAreaMore.Size = new System.Drawing.Size(153, 57);
            this.btnCountryAreaMore.TabIndex = 11;
            this.btnCountryAreaMore.Text = "Отобразить название стран с площадью больше...\r\n";
            this.btnCountryAreaMore.UseVisualStyleBackColor = true;
            this.btnCountryAreaMore.Click += new System.EventHandler(this.btnCountryAreaMore_Click);
            // 
            // btnGetEuropianCountry
            // 
            this.btnGetEuropianCountry.Location = new System.Drawing.Point(503, 183);
            this.btnGetEuropianCountry.Name = "btnGetEuropianCountry";
            this.btnGetEuropianCountry.Size = new System.Drawing.Size(259, 46);
            this.btnGetEuropianCountry.TabIndex = 10;
            this.btnGetEuropianCountry.Text = "Отобразить название всех европейских стран";
            this.btnGetEuropianCountry.UseVisualStyleBackColor = true;
            this.btnGetEuropianCountry.Click += new System.EventHandler(this.btnGetEuropianCountry_Click);
            // 
            // btnUpdCountry
            // 
            this.btnUpdCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdCountry.Location = new System.Drawing.Point(672, 61);
            this.btnUpdCountry.Name = "btnUpdCountry";
            this.btnUpdCountry.Size = new System.Drawing.Size(90, 48);
            this.btnUpdCountry.TabIndex = 9;
            this.btnUpdCountry.Text = "Изменить  страну";
            this.btnUpdCountry.UseVisualStyleBackColor = true;
            this.btnUpdCountry.Click += new System.EventHandler(this.btnUpdCountry_Click);
            // 
            // btnDeleteCountry
            // 
            this.btnDeleteCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCountry.Location = new System.Drawing.Point(672, 115);
            this.btnDeleteCountry.Name = "btnDeleteCountry";
            this.btnDeleteCountry.Size = new System.Drawing.Size(90, 48);
            this.btnDeleteCountry.TabIndex = 8;
            this.btnDeleteCountry.TabStop = false;
            this.btnDeleteCountry.Text = "Удалить страну";
            this.btnDeleteCountry.UseVisualStyleBackColor = true;
            this.btnDeleteCountry.Click += new System.EventHandler(this.btnDeleteCountry_Click);
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCountry.Location = new System.Drawing.Point(672, 7);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(90, 48);
            this.btnAddCountry.TabIndex = 7;
            this.btnAddCountry.Text = "Добавить страну";
            this.btnAddCountry.UseVisualStyleBackColor = true;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // countryDataGrid
            // 
            this.countryDataGrid.AllowUserToAddRows = false;
            this.countryDataGrid.AllowUserToDeleteRows = false;
            this.countryDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.countryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.countryDataGrid.Location = new System.Drawing.Point(6, 7);
            this.countryDataGrid.Name = "countryDataGrid";
            this.countryDataGrid.RowHeadersVisible = false;
            this.countryDataGrid.RowTemplate.Height = 25;
            this.countryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.countryDataGrid.Size = new System.Drawing.Size(491, 384);
            this.countryDataGrid.TabIndex = 0;
            // 
            // CityTabs
            // 
            this.CityTabs.Controls.Add(this.button1);
            this.CityTabs.Controls.Add(this.btnCapitalMore);
            this.CityTabs.Controls.Add(this.label1);
            this.CityTabs.Controls.Add(this.comboBoxCountrySelected);
            this.CityTabs.Controls.Add(this.btnUpdCity);
            this.CityTabs.Controls.Add(this.btnDeleteCity);
            this.CityTabs.Controls.Add(this.btnAddCity);
            this.CityTabs.Controls.Add(this.сitiesDataGrid);
            this.CityTabs.Location = new System.Drawing.Point(4, 24);
            this.CityTabs.Name = "CityTabs";
            this.CityTabs.Padding = new System.Windows.Forms.Padding(3);
            this.CityTabs.Size = new System.Drawing.Size(768, 398);
            this.CityTabs.TabIndex = 1;
            this.CityTabs.Text = "Города";
            this.CityTabs.UseVisualStyleBackColor = true;
            // 
            // btnCapitalMore
            // 
            this.btnCapitalMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapitalMore.Location = new System.Drawing.Point(540, 184);
            this.btnCapitalMore.Name = "btnCapitalMore";
            this.btnCapitalMore.Size = new System.Drawing.Size(221, 58);
            this.btnCapitalMore.TabIndex = 16;
            this.btnCapitalMore.TabStop = false;
            this.btnCapitalMore.Text = "Столицы с населением болие 5М";
            this.btnCapitalMore.UseVisualStyleBackColor = true;
            this.btnCapitalMore.Click += new System.EventHandler(this.btnCapitalMore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Показать по стране";
            // 
            // comboBoxCountrySelected
            // 
            this.comboBoxCountrySelected.AllowDrop = true;
            this.comboBoxCountrySelected.FormattingEnabled = true;
            this.comboBoxCountrySelected.Location = new System.Drawing.Point(126, 9);
            this.comboBoxCountrySelected.Name = "comboBoxCountrySelected";
            this.comboBoxCountrySelected.Size = new System.Drawing.Size(199, 23);
            this.comboBoxCountrySelected.TabIndex = 14;
            this.comboBoxCountrySelected.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountrySelected_SelectedIndexChanged);
            // 
            // btnUpdCity
            // 
            this.btnUpdCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdCity.Location = new System.Drawing.Point(672, 61);
            this.btnUpdCity.Name = "btnUpdCity";
            this.btnUpdCity.Size = new System.Drawing.Size(90, 48);
            this.btnUpdCity.TabIndex = 13;
            this.btnUpdCity.Text = "Изменить  город";
            this.btnUpdCity.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCity
            // 
            this.btnDeleteCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCity.Location = new System.Drawing.Point(672, 115);
            this.btnDeleteCity.Name = "btnDeleteCity";
            this.btnDeleteCity.Size = new System.Drawing.Size(90, 48);
            this.btnDeleteCity.TabIndex = 12;
            this.btnDeleteCity.TabStop = false;
            this.btnDeleteCity.Text = "Удалить город";
            this.btnDeleteCity.UseVisualStyleBackColor = true;
            // 
            // btnAddCity
            // 
            this.btnAddCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCity.Location = new System.Drawing.Point(672, 7);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(90, 48);
            this.btnAddCity.TabIndex = 11;
            this.btnAddCity.Text = "Добавить город";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // сitiesDataGrid
            // 
            this.сitiesDataGrid.AllowUserToAddRows = false;
            this.сitiesDataGrid.AllowUserToDeleteRows = false;
            this.сitiesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.сitiesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.сitiesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сitiesDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.сitiesDataGrid.Location = new System.Drawing.Point(4, 38);
            this.сitiesDataGrid.Name = "сitiesDataGrid";
            this.сitiesDataGrid.RowHeadersVisible = false;
            this.сitiesDataGrid.RowTemplate.Height = 25;
            this.сitiesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.сitiesDataGrid.Size = new System.Drawing.Size(530, 353);
            this.сitiesDataGrid.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Отобразить все столицы, у которых в названии есть буквы a, p";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.mainTabControl);
            this.Name = "MainForm";
            this.Text = "Страны";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.CountryTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeriCountryArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataGrid)).EndInit();
            this.CityTabs.ResumeLayout(false);
            this.CityTabs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сitiesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl mainTabControl;
        private TabPage CountryTabs;
        private TabPage CityTabs;
        private DataGridView countryDataGrid;
        private Button btnUpdCountry;
        private Button btnDeleteCountry;
        private Button btnAddCountry;
        private Button btnUpdCity;
        private Button btnDeleteCity;
        private Button btnAddCity;
        private DataGridView сitiesDataGrid;
        private Label label1;
        private ComboBox comboBoxCountrySelected;
        private Button btnCapitalMore;
        private Button btnGetEuropianCountry;
        private Button btnCountryAreaMore;
        private NumericUpDown numeriCountryArea;
        private Button button1;
    }
}