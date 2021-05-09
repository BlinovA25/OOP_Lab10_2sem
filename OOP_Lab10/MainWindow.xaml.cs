using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace OOP_Lab10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //string connectionString;
        //SqlDataAdapter adapter;
        //DataTable fuelTable;

        public MainWindow()
        {
            InitializeComponent();
            // получаем строку подключения из app.config
            //connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void FuelButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Fuel();
        }

        private void ShopButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Shop();
        }

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    string sql = "SELECT * FROM FUEL";
        //    fuelTable = new DataTable();
        //    SqlConnection connection = null;

        //    try
        //    {
        //        connection = new SqlConnection(connectionString);
        //        SqlCommand command = new SqlCommand(sql, connection);
        //        adapter = new SqlDataAdapter(command);



        //        // установка команды на добавление для вызова хранимой процедуры

        //        //adapter.InsertCommand = new SqlCommand("sp_InsertFuel", connection);
        //        //adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
        //        //adapter.InsertCommand.Parameters.Add(new SqlParameter("@FuelID", SqlDbType.NVarChar, 50, "FuelID"));
        //        //adapter.InsertCommand.Parameters.Add(new SqlParameter("@FuelName", SqlDbType.NVarChar, 50, "FuelName"));
        //        //adapter.InsertCommand.Parameters.Add(new SqlParameter("@FuelCost", SqlDbType.Int, 0, "FuelCost"));
        //        //SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");
        //        //parameter.Direction = ParameterDirection.Output;

        //        connection.Open();
        //        MessageBox.Show("подключение открыто");

        //        adapter.Fill(fuelTable);
        //        MessageBox.Show("данные занесены в таблицу");

        //        fuelGrid.ItemsSource = fuelTable.DefaultView;
        //        MessageBox.Show("данные занесены в datagrid");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        MessageBox.Show("ошибка");
        //    }
        //    finally
        //    {
        //        MessageBox.Show("finally");

        //        if (connection != null)
        //            connection.Close();
        //    }
        //}

        //private void UpdateDB()
        //{
        //    SqlCommandBuilder comandbuilder = new SqlCommandBuilder(adapter);
        //    adapter.Update(fuelTable);
        //}

        //private void updateButton_Click(object sender, RoutedEventArgs e)
        //{
        //    UpdateDB();
        //}

        //private void deleteButton_Click(object sender, RoutedEventArgs e)
        //{
        //    if (fuelGrid.SelectedItems != null)
        //    {
        //        for (int i = 0; i < fuelGrid.SelectedItems.Count; i++)
        //        {
        //            DataRowView datarowView = fuelGrid.SelectedItems[i] as DataRowView;
        //            if (datarowView != null)
        //            {
        //                DataRow dataRow = (DataRow)datarowView.Row;
        //                dataRow.Delete();
        //            }
        //        }
        //    }
        //    UpdateDB();
        //}

        //private void downloadButton_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("downloadButton_Click");

        //    string sql = "SELECT * FROM FUEL";
        //    fuelTable = new DataTable();
        //    SqlConnection connection = null;

        //    try
        //    {
        //        connection = new SqlConnection(connectionString);
        //        SqlCommand command = new SqlCommand(sql, connection);
        //        adapter = new SqlDataAdapter(command);



        //        // установка команды на добавление для вызова хранимой процедуры

        //        //adapter.InsertCommand = new SqlCommand("sp_InsertFuel", connection);
        //        //adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
        //        //adapter.InsertCommand.Parameters.Add(new SqlParameter("@FuelID", SqlDbType.NVarChar, 50, "FuelID"));
        //        //adapter.InsertCommand.Parameters.Add(new SqlParameter("@FuelName", SqlDbType.NVarChar, 50, "FuelName"));
        //        //adapter.InsertCommand.Parameters.Add(new SqlParameter("@FuelCost", SqlDbType.Int, 0, "FuelCost"));
        //        //SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");
        //        //parameter.Direction = ParameterDirection.Output;

        //        connection.Open();
        //        MessageBox.Show("подключение открыто");

        //        adapter.Fill(fuelTable);
        //        MessageBox.Show("данные занесены в таблицу");

        //        fuelGrid.ItemsSource = fuelTable.DefaultView;
        //        MessageBox.Show("данные занесены в datagrid");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        MessageBox.Show("ошибка");
        //    }
        //    finally
        //    {
        //        MessageBox.Show("finally");

        //        if (connection != null)
        //            connection.Close();
        //    }
        //}
    }
}
