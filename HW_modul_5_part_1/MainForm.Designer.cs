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
            this.countryDataGrid = new System.Windows.Forms.DataGridView();
            this.CityTabs = new System.Windows.Forms.TabPage();
            this.mainTabControl.SuspendLayout();
            this.CountryTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataGrid)).BeginInit();
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
            // 
            // CountryTabs
            // 
            this.CountryTabs.Controls.Add(this.countryDataGrid);
            this.CountryTabs.Location = new System.Drawing.Point(4, 24);
            this.CountryTabs.Name = "CountryTabs";
            this.CountryTabs.Padding = new System.Windows.Forms.Padding(3);
            this.CountryTabs.Size = new System.Drawing.Size(768, 398);
            this.CountryTabs.TabIndex = 0;
            this.CountryTabs.Text = "Страны";
            this.CountryTabs.UseVisualStyleBackColor = true;
            // 
            // countryDataGrid
            // 
            this.countryDataGrid.AllowUserToAddRows = false;
            this.countryDataGrid.AllowUserToDeleteRows = false;
            this.countryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryDataGrid.Location = new System.Drawing.Point(9, 8);
            this.countryDataGrid.Name = "countryDataGrid";
            this.countryDataGrid.RowTemplate.Height = 25;
            this.countryDataGrid.Size = new System.Drawing.Size(619, 384);
            this.countryDataGrid.TabIndex = 0;
            // 
            // CityTabs
            // 
            this.CityTabs.Location = new System.Drawing.Point(4, 24);
            this.CityTabs.Name = "CityTabs";
            this.CityTabs.Padding = new System.Windows.Forms.Padding(3);
            this.CityTabs.Size = new System.Drawing.Size(768, 398);
            this.CityTabs.TabIndex = 1;
            this.CityTabs.Text = "Города";
            this.CityTabs.UseVisualStyleBackColor = true;
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
            this.mainTabControl.ResumeLayout(false);
            this.CountryTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countryDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl mainTabControl;
        private TabPage CountryTabs;
        private TabPage CityTabs;
        private DataGridView countryDataGrid;
    }
}