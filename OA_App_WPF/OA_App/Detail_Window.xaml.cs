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
using Microsoft.Win32;
using System.IO;


using OA_App.SRef;

namespace OA_App
{
    /// <summary>
    /// Interaction logic for Detail_Window.xaml
    /// </summary>
    public partial class Detail_Window : Window
    {

        String sdate = "";
        String edate = "";

        Service1Client SC = new Service1Client();

        public Detail_Window(Project_Table Item)
        {
            try
            {
                InitializeComponent();

                Initialize_All_Component(Item);

            }
            catch (Exception)
            {
                this.Close();
            }

        }

        void Initialize_All_Component(Project_Table Item)
        {
            txtProjId.Text = Item.Proj_Id.ToString();
            txtProjName.Text = Item.Proj_Name;
            txtProjDes.Text = Item.Proj_Des;
            txtProjSdate.Text = Item.Proj_Sdate.ToString("dd-MM-yyyy");
            txtProjEdate.Text = Item.Proj_Edate.ToString("dd-MM-yyyy");
            sdate = Item.Proj_Sdate.ToString("yyyy-MM-dd");
            edate = Item.Proj_Edate.ToString("yyyy-MM-dd");
            txtEmployeeName.Text = Item.Emp_Name;
            txtStatus.Text = Item.Proj_Status;

            if ((Item.Proj_Status).Equals("In Progress"))
                btnDownload.IsEnabled = false;

        }


        private void btn_Exit_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_Edit_Click_1(object sender, RoutedEventArgs e)
        {
            char status = 'O';

            if ((txtStatus.Text).Equals("Completed"))
            {
                status = 'C';
            }


            Add_Project Ap = new Add_Project(int.Parse(txtProjId.Text), txtProjName.Text, txtProjDes.Text, sdate, edate, txtEmployeeName.Text, status, 'Y');

            Ap.Show();
            this.Hide();
        }

        private void btn_Back_Click_1(object sender, RoutedEventArgs e)
        {
            Project_Window PW = new Project_Window();
            PW.Show();
            this.Close();

        }

        private void btnDownload_Click(object sender, RoutedEventArgs e)

        {
            try
            {
   
                int test = int.Parse(txtProjId.Text);
            
                byte[] downloadFile = SC.DownloadCompleteDocument(test);

             if (downloadFile != null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();

                    //set default file 
                    saveFileDialog.Filter = "Word Files | *.docx";
                    saveFileDialog.DefaultExt = "docx";
                    if (saveFileDialog.ShowDialog() == true)
                    {
                        //save file 
                        File.WriteAllBytes(saveFileDialog.FileName, downloadFile);
                        MessageBox.Show("Download Completed.", "Office Affiliates", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    }

                }
                else
                {
                    MessageBox.Show("Can't find file specified.", "Office Affiliates", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error.Please try again.", "Office Affiliates", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
          }
            

        }
    }

