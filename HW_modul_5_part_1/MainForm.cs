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
            LoadTabMethods = new ()
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
        }

        private void MainForm_Load(object sender, EventArgs e)  // ќб€ательно при запуске  дл€ старта загрузки данных из базы
        {
            LoadTabMethods[0]();
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {

        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCities();
        }
    }
}