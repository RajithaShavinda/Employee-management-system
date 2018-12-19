using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using OA_App.SRef;

namespace OA_App
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SRef.Service1Client Ref = new Service1Client();


        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;//focus the user name text field
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            txtUname.Focus();
        }

        void Navigate_Windows()
        {
            try
            {
                String[] Data = new String[2]; // to get password and user type separetly



                if (txtUname.Text.Equals("")) //if user do not enter the user name
                {
                    MessageBox.Show("Please enter Username and Password to login", "Access Deny", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {//else1


                    if ((txtpassword.Password).Equals(""))//if user do not enter the password
                    {
                        MessageBox.Show("Please enter the Password to login", "Access Deny", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {//else2

                        Data[0] = Ref.Select_LogInDetails(txtUname.Text);

                        Data = Data[0].Split('\u2248'); //get password & user type separately | password--> Data[0] | userType-->Data[1]





                        if (Data[0].Equals(txtpassword.Password)) //compare DB password and user enterd password
                        {
                            if (Data[1].Equals("Admin"))//user type==Admin --> navigate to Project Window
                            {
                                Project_Window PW = new Project_Window();

                                PW.Show();
                                this.Close();
                            }
                            else if (Data[1].Equals("Employee"))//user type==Employee --> navigate to Employee Window
                            {
                                Employee_Window EW = new Employee_Window(txtUname.Text);

                                EW.Show();
                                this.Close();
                            }

                            else // DB error --> User Type column Empty
                                MessageBox.Show("Error in Data Base");
                        }
                        else // User Input error --> Invalid Password
                        {
                            MessageBox.Show("Invalid User Name or Password ", "Access Deny", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }//else2
                }//else1

            }//try
            catch (NullReferenceException)
            {
                MessageBox.Show("Incorrect User Name", "Access Deny", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            catch (Exception)
            {

                MessageBox.Show("Internet connection error", "Access Deny", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }




        private void btn_LogIn_Click_1(object sender, RoutedEventArgs e)
        {
            Navigate_Windows();


        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.Key == Key.Enter)
            {
                Navigate_Windows();


            }
        }

        private void txtUname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtpassword.Focus();


            }
        }


    }
}
