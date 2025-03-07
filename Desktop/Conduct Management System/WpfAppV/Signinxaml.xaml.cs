using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
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
    /// Interaction logic for Signinxaml.xaml
    /// </summary>
    public partial class Signinxaml : Window
    {
        public Signinxaml()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            var Username = UserNameText.Text;
            var Password = PasswordText.Password;

            
                using (UserDataContext context = new UserDataContext())
            {

                bool userfound = context.User.Any(user => user.Name == Username && user.Password == Password);
                {
                    if(userfound)
                    {
                        GrantAccess();
                        Close();

                    }
                    else
                    {
                        MessageBox.Show("User not Found");
                    }
                }
            }
            this.Close();

        }

        public void GrantAccess()
        {
            ConductDetails conductDetailsWindow = new ConductDetails();
            conductDetailsWindow.ShowDialog();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConductDetails conductDetailsWindow = new ConductDetails();
            conductDetailsWindow.ShowDialog();
            this.Close();
        }
        
        

    }
}
