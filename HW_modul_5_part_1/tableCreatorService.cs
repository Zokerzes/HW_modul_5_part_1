using AdoNetWinformsApp.Entities;
using HW_modul_5_part_1.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetWinformsApp.Servises
{
    public class TableCreatorService
    {
        public static DataTable CreateCountryTable(List<Country> countries) //собираем таблицу
        {
            DataTable table = new DataTable();
            table.Clear();
            table.Columns.Add("Id");
            table.Columns.Add("Название страны");
            table.Columns.Add("Площадь");
            table.Columns.Add("Часть мира");

            foreach (var country in countries )
            {
                DataRow row = table.NewRow();
                row[0] = country.Id;
                row[1] = country.Name;
                row[2] = country.Area;
                row[3] = country.PartOfWord;
                table.Rows.Add(row);
            }

            return table;
        }
        public static DataTable CreateCityTable(List<City> cities) //собираем таблицу
        {
            DataTable table = new DataTable();
            table.Clear();
            table.Columns.Add("Id");
            table.Columns.Add("Название");
          

            foreach (var city in cities)
            {
                DataRow row = table.NewRow();
                row[0] = city.Id;
                row[1] = city.Name;
                row[2] = city.Population;
                row[3] = city.IsCapital;

                table.Rows.Add(row);
            }
            return table;
        }

        public static void ShowTable(DataGridView grid, DataTable table)
        {
            grid.DataSource = null;
            grid.DataSource = table;
            grid.Columns[0].Visible = false;   //прячем 1ю колонку

        }

    }
}
