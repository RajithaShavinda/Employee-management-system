using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

using System.Globalization;

using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Microsoft.Win32;

using OA_App.SRef;
using System.IO;


namespace OA_App
{
    /// <summary>
    /// Interaction logic for Add_Project.xaml
    /// </summary>
    public partial class Add_Project : Window
    {
        int next_Project_Id;


        DateTime Start_Date = new DateTime(); //store project started date

        DateTime End_Date = new DateTime(); //store project end date

        int count = 35;//Usage: project name field --o--> text change event --o--> count characters

        String Emp_Name = ""; // Store Employee Same

        char Update = 'Y'; //Interface mode ---o--> 'Y'-Update project  | 'N'-Add project



        SRef.Service1Client Ref = new Service1Client(); //Service References



        public Add_Project(int id, String name, String des, String sd, String ed, String emp, char status, char update)
        {
            InitializeComponent();

            Loaded += Add_Project_Loaded; //load combo box
            Initialize_All_Component(id, name, des, sd, ed, emp, status, update);

        }
        //------------------------------------------------------------------------------

        void Add_Project_Loaded(object sender, RoutedEventArgs e)
        {


            foreach (var item in Ref.get_All_EmployeeDeatils())
            {
                Combo.Items.Add(item.Emp_Name);

            }

        }
        //------------------------------------------------------------------------------


        void Initialize_All_Component(int id, String name, String des, String sd, String ed, String emp, char status, char update)
        {
            try
            {

                txtProjID.Text = id.ToString();

                txtProjName.Text = name;

                txtProjDes.Text = des;

                Update = update;

                Emp_Name = emp;

                //set value for the employee text field
                if (!(Emp_Name.Equals("")))
                {
                    txtEmployeeName_Gray.Text = "Selected Employee: " + Emp_Name;
                }
                else
                {
                    txtEmployeeName_Gray.Text = "Please Select an Employee";
                }


                //Update Project--0--> Update Mode='Y'(Yes)
                if (update == 'Y')
                {
                    btn_Delete.IsEnabled = true;

                    this.btn_Add.Content = "Update This Project";

                    SDatePicker.Text = sd;

                    EDatePicker.Text = ed;

                    //check the current project status | completed or ongoing
                    if (status == 'C')
                    {
                        rbnCompleted.IsChecked = true;

                        rbnOngoing.IsChecked = false;
                    }
                    else
                    {
                        rbnOngoing.IsChecked = true;

                        rbnCompleted.IsChecked = false;
                    }


                }
                else//New project |  Update Mode='N'(No)
                {
                    btn_Delete.IsEnabled = false;

                    this.btn_Add.Content = "Add This Project";


                    rbnCompleted.IsEnabled = false;

                    rbnOngoing.IsEnabled = false;

                    lblMark.IsEnabled = false;
                }

            }
            catch (Exception) { }
        }
        //------------------------------------------------------------------------------


        private void btn_Exit_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //------------------------------------------------------------------------------

        private void btn_Emp_stats_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Employee_Stats_Window ESW = new Employee_Stats_Window();
                ESW.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in network connection", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        //------------------------------------------------------------------------------

        private void btn_Project_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Project_Window PW = new Project_Window();
                PW.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in network connection", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        //------------------------------------------------------------------------------


        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            txtEmployeeName_Gray.Text = "Selected Employee: " + (String)Combo.SelectedItem;
        }
        //------------------------------------------------------------------------------


        private void btn_Delete_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

                MessageBoxResult MR1 = MessageBox.Show("Are you sure you want to permanently delete this project ?", " ", MessageBoxButton.YesNoCancel);

                if (MR1 == MessageBoxResult.Yes)
                {
                    MessageBoxResult MR2 = MessageBox.Show("Please Confirm to complete the task ?", " ", MessageBoxButton.YesNo);
                    if (MR2 == MessageBoxResult.Yes)
                    {
                        if (Ref.Delete_Project(int.Parse(txtProjID.Text)))
                        {
                            MessageBox.Show("Successfully Deleted ");
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error in network connection", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        //------------------------------------------------------------------------------


        private void btn_Add_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int result = 0;

                String fields = ":";

                int id = int.Parse(txtProjID.Text);

                String name = txtProjName.Text;

                String des = txtProjDes.Text;

                DateTime sdate = DateTime.Parse(Start_Date.ToString("yyyy-MM-dd"));

                DateTime edate = DateTime.Parse(End_Date.ToString("yyyy-MM-dd"));

                Char status = 'O';



                if (Combo.SelectedValue != null)
                {
                    Emp_Name = (String)Combo.SelectedItem;

                    txtEmployeeName_Gray.Text = "Selected Employee: " + Emp_Name;
                }

                if (rbnCompleted.IsChecked == true)
                {
                    status = 'C';
                }



                txtNameCount.Foreground = Brushes.Green;
                txtNameCount.Text = "\u221A";

                txtsdate.Foreground = Brushes.Green;
                txtsdate.Text = "\u221A";

                txtedate.Foreground = Brushes.Green;
                txtedate.Text = "\u221A";

                txtEmployee.Foreground = Brushes.Green;
                txtEmployee.Text = "\u221A";



                if (txtProjName.Text.Equals(""))
                {
                    fields = "\u2022\u001A Project Name   ";

                    txtNameCount.Foreground = Brushes.Red;
                    txtNameCount.Text = "X";
                }

                if (Start_Date.ToString("dd/M/yyyy").Equals("01/1/0001"))
                {
                    fields += "\u2022\u001A Start Date   ";

                    txtsdate.Foreground = Brushes.Red;
                    txtsdate.Text = "X";
                }



                result = DateTime.Compare(sdate, edate);//compare date |end date must larger than the stated date

                if (End_Date.ToString("dd/M/yyyy").Equals("01/1/0001"))
                {
                    fields += "\u2022\u001A End Date   ";

                    txtedate.Foreground = Brushes.Red;
                    txtedate.Text = "X";
                }
                else//end date field is not empty
                {
                    if (result >= 0)//end date smaller than started date
                    {
                        MessageBox.Show("Invalid End date", "Not Updated", MessageBoxButton.OK, MessageBoxImage.Information);
                        fields += "\u2022\u001A End Date   ";

                        txtedate.Foreground = Brushes.Red;
                        txtedate.Text = "X";
                    }
                }




                if (Emp_Name.Equals(""))
                {
                    fields += "\u2022\u001A Employee   ";

                    txtEmployee.Foreground = Brushes.Red;
                    txtEmployee.Text = "X";
                }





                //------------------------------------------------------------------------------Update Method
                if (Update == 'Y')
                {


                    if ((fields.Equals(":")) && result <= 0)//check empty text boxes & Valid end date
                    {

                        Ref.Update_Project(id, name, des, sdate, edate, status, Emp_Name);

                        MessageBox.Show("Sucessfully Updated", "Update Project ", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    else //update
                    {
                        MessageBox.Show("Please insert valid data into : " + fields + " Field/Fields", "Not Updated", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                //------------------------------------------------------------------------------Insert
                else//Add new project  
                {

                    if ((fields.Equals(":")) && result <= 0)//check empty text boxes & Valid end date
                    {

                        Ref.Insert_Project(id, name, des, sdate, edate, Emp_Name);

                        MessageBox.Show("Sucessfully Added", "Add Project ", MessageBoxButton.OK, MessageBoxImage.Information);


                    }
                    else  //insert new row
                    {

                        MessageBox.Show("Please insert valid data into : " + fields + " Field/Fields", "Not Inserted", MessageBoxButton.OK, MessageBoxImage.Information);
                    }

                }//else Add new project
            }//try
            catch (Exception)
            {
                MessageBox.Show("Error in network connection", "", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }//------------------------------------------------------------------------------\u221E infinite   \u2248 ~~




        private void SDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var picker = sender as DatePicker;

            DateTime? sdate = picker.SelectedDate;

            if (sdate == null)
            {
            }
            else
            {
                Start_Date = (DateTime)sdate;
            }
        }
        //------------------------------------------------------------------------------


       
        /*
        private void btnUpload_Click_1(object sender, RoutedEventArgs e)
        {

                if (result == true)
                {
                    // Open document
                    filename = openFileDialog.FileName;
                    txtInformation.Text = filename;
                }

        */

        //------------------------------------------------------------------------------
        private void EDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var picker = sender as DatePicker;

            DateTime? edate = picker.SelectedDate;

            if (edate == null)
            {
            }
            else
            {
                End_Date = (DateTime)edate;
            }
        }


        //------------------------------------------------------------------------------
        private void txtProjName_TextChanged(object sender, TextChangedEventArgs e)
        {
            int left = count - txtProjName.Text.Length;
            txtNameCount.Text = left + " Letters Left";

            if (left <= 0)
            {
                txtNameCount.Foreground = Brushes.Red;
                txtNameCount.Text = "No more than 35 letters!";
            }
            else
            {
                txtNameCount.Foreground = Brushes.Blue;
            }
        }


        //------------------------------------------------------------------------------

        private void txtProjDes_MouseEnter(object sender, MouseEventArgs e)
        {

            if (txtProjName.Text.Length >= 1 && txtProjName.Text.Length <= 35)
            {
                txtNameCount.Foreground = Brushes.Green;
                txtNameCount.Text = "\u221A";//((char)0x221A).ToString()
            }
            else
            {
                txtNameCount.Foreground = Brushes.Red;
                txtNameCount.Text = "X";
            }
        }

        private void btnUpload_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.DefaultExt = ".docx";
                fileDialog.Filter = "Word Files | *.docx";


                if (fileDialog.ShowDialog() == true)
                {
                    //get file array from selected document 
                    byte[] uploadingFile = File.ReadAllBytes(fileDialog.FileName);

                    //get file 
                    string fileName = System.IO.Path.GetFileName(fileDialog.FileName);



                    int projId = int.Parse(txtProjID.Text);

                    //Call  service 
                    bool uploaded = Ref.UploadAdminFile(projId, fileName, uploadingFile);

                    if (uploaded == true)
                    {
                        MessageBox.Show("Successfully uploaded.", "Office Affiliates", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Please try again.", "Office Affiliates", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong.Please try again.", "Office Affiliates", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
  
    }
}
