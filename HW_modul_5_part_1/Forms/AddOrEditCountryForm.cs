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
    public partial class AddOrEditCountryForm : Form
    {
        public string CountryName => txtCountryName.Text.Trim();
        public decimal CountryArea => numericArea.Value;
        public int CountryPartOfWorld => (int)partOfWorldComboBox.SelectedValue;
        public AddOrEditCountryForm(List<KeyValuePair<string, int>> countries)
        {
            InitializeComponent();
            PartOfWord(countries);
        }

        public AddOrEditCountryForm(List<KeyValuePair<string, int>> countries, string name, decimal area, int country)
        {
            //InitializeComponent();
            //this.Text = "Изменить товар";


            //textName.Text = name;
            //numericCost.Value = cost;
            //PopulateComboBox(goodTypes, goodTypeId);
        }

        private void PartOfWord(List<KeyValuePair<string, int>> countries)
        {
            throw new NotImplementedException();
        }
    }
}
