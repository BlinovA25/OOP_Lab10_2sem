using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_Lab10
{
    /// <summary>
    /// Логика взаимодействия для Fuel.xaml
    /// </summary>
    public partial class Fuel : Page
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable fuelTable;

        public Fuel()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void UpdateDB()
        {
            SqlCommandBuilder comandbuilder = new SqlCommandBuilder(adapter);
            adapter.Update(fuelTable);
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (fuelGrid.SelectedItems != null)
            {
                for (int i = 0; i < fuelGrid.SelectedItems.Count; i++)
                {
                    DataRowView datarowView = fuelGrid.SelectedItems[i] as DataRowView;
                    if (datarowView != null)
                    {
                        DataRow dataRow = (DataRow)datarowView.Row;
                        dataRow.Delete();
                    }
                }
            }
            UpdateDB();
        }

        private void downloadButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("downloadButton_Click");

            string sql = "begin tran; select * from FUEL; commit tran;";
            fuelTable = new DataTable();
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                connection.Open();
                //MessageBox.Show("подключение открыто");

                adapter.Fill(fuelTable);
                //MessageBox.Show("данные занесены в таблицу");

                fuelGrid.ItemsSource = fuelTable.DefaultView;
                //MessageBox.Show("данные занесены в datagrid");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("ошибка");
            }
            finally
            {
                //MessageBox.Show("finally");

                if (connection != null)
                    connection.Close();
            }
        }
    }
}
