using AdoNetWinformsApp.Entities.Constants;
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
        public AddOrEditCountryForm(List<KeyValuePair<string, int>> countries)
        {
            InitializeComponent();
            PartOfWorld();
        }

        public AddOrEditCountryForm(List<KeyValuePair<string, int>> countries, string name, decimal area, int countryId)
        {
            InitializeComponent();
            this.Text = "Изменить товар";

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
    }
}
