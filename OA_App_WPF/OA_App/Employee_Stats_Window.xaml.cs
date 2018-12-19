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
using System.Windows.Shapes;

using OA_App.SRef;

namespace OA_App
{
    /// <summary>
    /// Interaction logic for Employee_Stats_Window.xaml
    /// </summary>
    public partial class Employee_Stats_Window : Window
    {
        SRef.Service1Client Ref = new Service1Client();
        public Employee_Stats_Window()
        {
            try
            {
                InitializeComponent();

                My_Data_List.ItemsSource = Ref.get_All_EmployeeDeatils();
            }
            catch (Exception)
            {
                MessageBox.Show("Error In Network Connection");
            }
        }





        private void btn_Update_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                tabUpdate.Focus();

                tabAdd.IsEnabled = false;

                Employee_Table selected = (Employee_Table)My_Data_List.SelectedItem;

                txtUpdate_EMP_Id_emp_t.Text = selected.Emp_Id;
                txtUpdate_EMP_Name.Text = selected.Emp_Name;
                txtUpdate_EMP_email.Text = selected.Email;
                txtUpdate_EMP_contact.Text = selected.Contact;

                txtUpdate_EMP_Id.Text = selected.Emp_Id;


            }
            catch (Exception) { MessageBox.Show("Please select a employee recode"); }


        }





        private void btn_Add_Employeee_Click_1(object sender, RoutedEventArgs e)
        {
            {
                String id = Emp_Id.Text;

                if (Emp_Pass.Password.Equals(Emp_Pass2.Password))
                {


                    String name = Emp_Name.Text;
                    String Email = Emp_Email.Text;
                    String contact = Emp_Contact.Text;



                    if (Ref.Insert_Employee_UserLogin_Table(id, Emp_Pass.Password))
                    {
                        MessageBox.Show("Employee login details Successfully Added", "Employee Log in Details", MessageBoxButton.OK, MessageBoxImage.Information);
                        My_Data_List.ItemsSource = Ref.get_All_EmployeeDeatils();
                    }
                    else
                    {
                        MessageBox.Show("Please Insert the Employee details");
                    }

                    if (Ref.Insert_Employee(id, name, Email, contact))
                    {
                        MessageBox.Show("Employee details Successfully Added", "Employee List", MessageBoxButton.OK, MessageBoxImage.Information);
                        My_Data_List.ItemsSource = Ref.get_All_EmployeeDeatils();
                    }
                    else
                    {
                        MessageBox.Show("Please Insert the Employee details");
                    }

                }
                else
                    MessageBox.Show("Passwords are not matching ");


            }
        }



        private void btn_ExitA_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }




        private void btn_Update_Employeee_Click_1(object sender, RoutedEventArgs e)
        {

            String id = txtUpdate_EMP_Id_emp_t.Text;
            String name = txtUpdate_EMP_Name.Text;
            String email = txtUpdate_EMP_email.Text;
            String contact = txtUpdate_EMP_contact.Text;

            if (Ref.Update_Employee_table(id, name, email, contact))
            {
                MessageBox.Show("Employee list successfully updated");
                My_Data_List.ItemsSource = Ref.get_All_EmployeeDeatils();
            }
            else
            {
                MessageBox.Show("Error");
            }

            tabAdd.IsEnabled = true;

        }



        private void btn_ExitU_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



        private void btn_Delete_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {

                Employee_Table selected = (Employee_Table)My_Data_List.SelectedItem;

                String id = selected.Emp_Id;

                MessageBoxResult MR0 = MessageBox.Show("Are you sure you want to permanently delete this Employee ?", " ", MessageBoxButton.YesNoCancel, MessageBoxImage.Information);

                if (MR0 == MessageBoxResult.Yes)
                {

                    if (Ref.Delete_Employee_form_Emp_table(id))
                    {
                        MessageBox.Show("Successfully Deleted the recode from Employee table");

                        MessageBoxResult MR1 = MessageBox.Show("do you want to delete this recode from the User Login table ?", " ", MessageBoxButton.YesNoCancel);

                        if (MR1 == MessageBoxResult.Yes)
                        {
                            MessageBoxResult MR2 = MessageBox.Show("Please Confirm to complete the task ?", " ", MessageBoxButton.YesNo);
                            if (MR2 == MessageBoxResult.Yes)
                            {
                                if (Ref.Delete_Employee_form_User_Login_table(id))
                                {
                                    MessageBox.Show("Successfully Deleted the recode from UserLogin");
                                }
                                else
                                {
                                    MessageBox.Show("Error");
                                }
                            }
                        }

                        My_Data_List.ItemsSource = Ref.get_All_EmployeeDeatils();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a employee recode");
            }
        }




        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Project_Window PW = new Project_Window();

            PW.Show();
            this.Close();
        }





        private void txtUpdate_EMP_password_1_MouseEnter(object sender, MouseEventArgs e)
        {
            txtShowPassword.Text = txtUpdate_EMP_password_1.Password;
        }

        private void Grid_MouseEnter_1(object sender, MouseEventArgs e)
        {
            txtShowPassword.Text = "";
        }

        private void txtUpdate_EMP_password_2_MouseEnter(object sender, MouseEventArgs e)
        {
            txtShowPassword.Text = txtUpdate_EMP_password_2.Password;
        }





        private void btn_Update_Employee_Login_Click_1(object sender, RoutedEventArgs e)
        {


            String id = txtUpdate_EMP_Id.Text;
            String paswrd = txtUpdate_EMP_password_2.Password;

            if ((txtUpdate_EMP_password_1.Password).Equals(txtUpdate_EMP_password_2.Password))
            {

                if (Ref.Update_Employee_UserLogin_Table(id, paswrd))
                {
                    MessageBox.Show("Log in details successfully updated");
                    My_Data_List.ItemsSource = Ref.get_All_EmployeeDeatils();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else { MessageBox.Show("Entered Passwords are not match."); }
        }
       
    }
}
