using AdoNetWinformsApp;
using AdoNetWinformsApp.Servises;

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
                {1,() =>LoadCities() },
            };

        }

        private async void LoadCities()
        {
            TableCreatorService.ShowTable(
                 countryDataGrid,
                 TableCreatorService.CreateCountryTable(await _countryService.GetCountries()));
        }

        private async void LoadCountries()
        {
            TableCreatorService.ShowTable(
                countryDataGrid,
                TableCreatorService.CreateCountryTable(await _countryService.GetCountries()));
        }
    }
}