using AdoNetWinformsApp.Entities.Constants;
using AdoNetWinformsApp.EntityMappings;
using HW_modul_5_part_1.Servises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_modul_5_part_1.Forms
{
    public partial class AddOrEditCountryForm : Form
    {
        public string CountryName => txtCountryName.Text.Trim();
        public decimal CountryArea => numericArea.Value;
        public int CountryPartOfWorld => (int)partOfWorldComboBox.SelectedValue;
        public AddOrEditCountryForm()
        {
            InitializeComponent();
            PartOfWorld();
        }

        public AddOrEditCountryForm(string name, decimal area)
        {
            InitializeComponent();
            Text = "Изменить страну";

            txtCountryName.Text = name;
            numericArea.Value = area;
            PartOfWorld();
        }

        private void PartOfWorld()
        {
            var pairs = new List<KeyValuePair<string, int>>();
            pairs.Add(new("Не выбрана", 0));
            var enumValues = Enum.GetValues<PartOfWorld>();
            pairs.AddRange(enumValues.Select(x => new KeyValuePair<string, int>(x.GetEnumDescription(), (int)x)));

            partOfWorldComboBox.DisplayMember = "Key";
            partOfWorldComboBox.ValueMember = "Value";
            partOfWorldComboBox.DataSource = pairs;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void txtCountryName_Validating(object sender, CancelEventArgs e)
        {

            if (txtCountryName.Text.Trim().Length > DataBaseDefault.StringValueMaxLenght)
            {
                nameError.SetError(txtCountryName, "Слишком длинное названия");
                e.Cancel = true;
            }
            else if (string.IsNullOrEmpty(txtCountryName.Text.Trim()))
            {
                nameError.SetError(txtCountryName, "Введите название страны");
                e.Cancel = true;
            }
            else
            {
                nameError.SetError(txtCountryName, String.Empty);
                e.Cancel = false;
            }
        }

        private void numericArea_Validating(object sender, CancelEventArgs e)
        {
            if (numericArea.Value <= 0)
            {
                areaError.SetError(numericArea, "Себестоимость должна быть больше 0");
                e.Cancel = true;
            }
            else
            {
                areaError.SetError(numericArea, String.Empty);
                e.Cancel = false;
            }
        }

        private void partOfWorldComboBox_Validating(object sender, CancelEventArgs e)
        {

            if ((int)partOfWorldComboBox.SelectedValue == 0)
            {
                partOfWorldError.SetError(partOfWorldComboBox, "Выберите тип товара");
                e.Cancel = true;
            }
            else
            {
                partOfWorldError.SetError(partOfWorldComboBox, String.Empty);
                e.Cancel = false;
            }
        }
    }
}
