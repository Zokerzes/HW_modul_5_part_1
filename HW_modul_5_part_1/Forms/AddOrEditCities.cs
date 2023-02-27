using AdoNetWinformsApp.Entities;
using AdoNetWinformsApp.Entities.Constants;
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
    public partial class AddOrEditCities : Form
    {
        public string CityName => nameCityTxt.Text.Trim();
        public int CityPopulation => (int)populationNumeric.Value;
        public bool IsCapital => IsCapitalCheckBox1.Checked;
        public int countryOfWorld => (int)countryComboBox.SelectedValue;

        public AddOrEditCities(List<KeyValuePair<string, int>> pairs)
        {
            InitializeComponent();
            CountryOfW(pairs);
        }

        private void CountryOfW(List<KeyValuePair<string, int>> countryPairs)
        {
            var pairs = new List<KeyValuePair<string, int>>();
            pairs.Add(new("Не выбрана", 0));
          
            pairs.AddRange(countryPairs);

            countryComboBox.DisplayMember = "Key";
            countryComboBox.ValueMember = "Value";
            countryComboBox.DataSource = pairs;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
