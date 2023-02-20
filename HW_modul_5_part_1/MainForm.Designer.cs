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
            this.btnUpdCountry = new System.Windows.Forms.Button();
            this.btnDeleteCountry = new System.Windows.Forms.Button();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.countryDataGrid = new System.Windows.Forms.DataGridView();
            this.CityTabs = new System.Windows.Forms.TabPage();
            this.btnUpdCity = new System.Windows.Forms.Button();
            this.btnDeleteCity = new System.Windows.Forms.Button();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.сitiesDataGrid = new System.Windows.Forms.DataGridView();
            this.mainTabControl.SuspendLayout();
            this.CountryTabs.SuspendLayout();
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
            this.countryDataGrid.Size = new System.Drawing.Size(660, 384);
            this.countryDataGrid.TabIndex = 0;
            // 
            // CityTabs
            // 
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
            this.сitiesDataGrid.Location = new System.Drawing.Point(4, 7);
            this.сitiesDataGrid.Name = "сitiesDataGrid";
            this.сitiesDataGrid.RowHeadersVisible = false;
            this.сitiesDataGrid.RowTemplate.Height = 25;
            this.сitiesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.сitiesDataGrid.Size = new System.Drawing.Size(661, 384);
            this.сitiesDataGrid.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTabControl);
            this.Name = "MainForm";
            this.Text = "Страны";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.CountryTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countryDataGrid)).EndInit();
            this.CityTabs.ResumeLayout(false);
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
    }
}