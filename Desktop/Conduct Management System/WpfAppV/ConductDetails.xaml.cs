using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Shapes;

namespace ConductManagementSystem
{
    /// <summary>
    /// Interaction logic for ConductDetails.xaml
    /// </summary>
    public partial class ConductDetails : Window
    {
        private DataBaseHelper _dbHelper;
        private Conduct selectedConduct;

        public ConductDetails()
        {
            InitializeComponent();
            _dbHelper = new DataBaseHelper();
            _dbHelper.InitializeDatabase();
            LoadConducts();
        }

        private void LoadConducts()
        {
            ConductGrid.ItemsSource = null;
            ConductGrid.ItemsSource = _dbHelper.GetAllConducts();
        }

        private void ConductGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ConductGrid.SelectedItem != null)
            {
                selectedConduct = ConductGrid.SelectedItem as Conduct;
                if (selectedConduct != null)
                {
                    txtName.Text = selectedConduct.Name;
                    txtEmail.Text = selectedConduct.Email;
                    txtContact.Text = selectedConduct.Contact;
                    txtAddress.Text = selectedConduct.Address;
                }
            }
        }

        private void AddConduct(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill all fields before adding.");
                return;
            }

            var conduct = new Conduct
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Contact = txtContact.Text,
                Address = txtAddress.Text
            };

            _dbHelper.AddConduct(conduct);
            LoadConducts();
            MessageBox.Show("Conduct added successfully!");

            // Clear text fields after adding
            ClearFields();
        }

        private void Update_Conduct(object sender, RoutedEventArgs e)
        {
            if (selectedConduct != null)
            {
                selectedConduct.Name = txtName.Text;
                selectedConduct.Email = txtEmail.Text;
                selectedConduct.Contact = txtContact.Text;
                selectedConduct.Address = txtAddress.Text;

                _dbHelper.UpdateConduct(selectedConduct);
                LoadConducts();
                MessageBox.Show("Conduct updated successfully!");

                // Clear selection and fields after update
                ConductGrid.SelectedItem = null;
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a conduct to update.");
            }
        }

        private void Delete_Conduct(object sender, RoutedEventArgs e)
        {
            if (selectedConduct != null)
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this conduct?", "Confirm Delete", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    _dbHelper.DeleteConduct(selectedConduct.ConductID);
                    LoadConducts();
                    MessageBox.Show("Conduct deleted successfully!");

                    // Clear selection and fields after delete
                    ConductGrid.SelectedItem = null;
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a conduct to delete.");
            }
        }

        private void ClearFields()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            selectedConduct = null;
        }

        private void Log_Out(object sender, RoutedEventArgs e)
        {
            MainWindow mainindow = new MainWindow();
            mainindow.Show();
            this.Close();
        }
        
    }

}