using AdoNetWinformsApp;
using AdoNetWinformsApp.Entities;
using AdoNetWinformsApp.Entities.Constants;
using AdoNetWinformsApp.Servises;
using HW_modul_5_part_1.Forms;
using Microsoft.Identity.Client;

namespace HW_modul_5_part_1
{
    public partial class MainForm : Form
    {
        private Dictionary<int, Action> LoadTabMethods;
        private readonly CountryService _countryService;

        public MainForm()
        {
            InitializeComponent();
            _countryService = new CountryService();
            LoadTabMethods = new()
            {
                {0,() =>LoadCountries() },
                {1,() =>LoadCities() }
            };

        }

       
        private async void LoadCountries()
        {
            TableCreatorService.ShowTable(
            countryDataGrid,
            TableCreatorService.CreateCountryTable(await _countryService.GetCountries()));
        }

        private async void LoadCities()
        {
            TableCreatorService.ShowTable(
            сitiesDataGrid,
            TableCreatorService.CreateCityTable(await _countryService.GetCities()));
            CountryCMB(await _countryService.GetCountriesPairs());
        }

        private async void ReLoadCities(int countryId)
        {
            TableCreatorService.ShowTable(
            сitiesDataGrid,
            TableCreatorService.CreateCityTable(await _countryService.GetCities(countryId)));
        }

        private async void GetCapital()
        {
            TableCreatorService.ShowTable(
            сitiesDataGrid,
            TableCreatorService.CreateCityTable(await _countryService.GetCapitalPopulationMore5M()));
        }



        private void MainForm_Load(object sender, EventArgs e)  // Обяательно при запуске  для старта загрузки данных из базы
        {
            LoadTabMethods[0]();
        }

        private async void btnAddCountry_Click(object sender, EventArgs e)
        {
            var form = new AddOrEditCountryForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                await _countryService.AddCountry(form.CountryName, form.CountryArea, (PartOfWorld)form.CountryPartOfWorld);
                LoadCountries();
            }
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTabMethods[mainTabControl.SelectedIndex]();
        }

        private async void btnUpdCountry_Click(object sender, EventArgs e)
        {
            if (countryDataGrid.SelectedRows.Count > 0)
            {
                var countryId = int.Parse(countryDataGrid.SelectedRows[0].Cells[0].Value.ToString()!);
                var country = await _countryService.GetCountryById(countryId);
                if (country == null)
                {
                    MessageBox.Show("Страна не найденa");
                    LoadCountries();
                    return;
                }

                try
                {
                    var form = new AddOrEditCountryForm(country.Name, country.Area);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        await _countryService.EditCountry(country, form.CountryName, form.CountryArea, form.CountryPartOfWorld);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LoadCountries();
                }
            }
            else
            {
                MessageBox.Show("выберите страну для изменения");
            }
        }

        private async void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            if (countryDataGrid.SelectedRows.Count > 0)
            {
                var countryId = int.Parse(countryDataGrid.SelectedRows[0].Cells[0].Value.ToString()!);
                try
                {
                    await _countryService.DeletedGood(countryId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LoadCountries();
                }
            }
            else
            {
                MessageBox.Show("выберите товар для удаления");
            }
        }

        private async void btnAddCity_Click(object sender, EventArgs e)
        {
            var pairs = await _countryService.GetCountriesPairs();
            // вернутся после сборки формы
            var form = new AddOrEditCities(pairs);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await _countryService.AddCity(form.CityName, form.CityPopulation, form.IsCapital, form.countryOfWorld);
                LoadCities();
            }
        }

        private  void comboBoxCountrySelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReLoadCities((int)comboBoxCountrySelected.SelectedValue);
        }

        private void CountryCMB( List<KeyValuePair<string, int>> countryPairs)
        {
            var pairs = new List<KeyValuePair<string, int>>();
            pairs.Add(new("Не выбрана", 0));

            pairs.AddRange(countryPairs);

            comboBoxCountrySelected.DisplayMember = "Key";
            comboBoxCountrySelected.ValueMember = "Value";
            comboBoxCountrySelected.DataSource = pairs;
        }

        private void btnCapitalMore_Click(object sender, EventArgs e)
        {
            GetCapital();
        }

        private void btnGetEuropianCountry_Click(object sender, EventArgs e)
        {
            LoadEuropianCountry();
        }

        private async void LoadEuropianCountry()
        {
          
            TableCreatorService.ShowTable(
            countryDataGrid,
            TableCreatorService.CreateCountryTable(await _countryService.GetEuroCountries()));
            
        }

        private async void btnCountryAreaMore_Click(object sender, EventArgs e)
        {
            TableCreatorService.ShowTable(
            countryDataGrid,
            TableCreatorService.CreateCountryTable( await _countryService.GetCountries((decimal)numeriCountryArea.Value)));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}