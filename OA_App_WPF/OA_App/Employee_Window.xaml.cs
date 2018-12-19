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


using OA_App.SRef;
using System.IO;

namespace OA_App
{
    /// <summary>
    /// Interaction logic for Employee_Window.xaml
    /// </summary>
    public partial class Employee_Window : Window
    {

        SRef.Service1Client Ref = new Service1Client();


        public Employee_Window(String id)
        {
            InitializeComponent();

            Load_Employee_Window(id);


        }

        void Load_Employee_Window(String id)
        {
            try
            {
                My_Data_List.ItemsSource = Ref.get_All_EmpWindowItems(id);
            }
            catch (Exception)
            {
                MessageBox.Show("Error In Network Connection");
            }
        }




        /// <summary>
        /// Uploads the document.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void UploadDocument(object sender, RoutedEventArgs e)
        {
            try
            {
                //Get the selected project from listox
                Project_Table project = (Project_Table)My_Data_List.SelectedItem;

                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.DefaultExt = ".docx"; // Required file extension 
                fileDialog.Filter = "Word Files | *.docx";


                if (fileDialog.ShowDialog() == true)
                {
                    //get file ayyay from selected file. 
                    byte[] uploadingFile = File.ReadAllBytes(fileDialog.FileName);
                    
                    //get file name with extention from selected file.
                    string fileName = System.IO.Path.GetFileName(fileDialog.FileName);

                    //Get project id from selected project
                    int projectId = project.Proj_Id;

                    //Call the service and upload file.
                    bool uploaded = Ref.UploadFile(projectId, fileName, uploadingFile);

                    if (uploaded == true)
                    {
                        MessageBox.Show("Successfully uploaded.", "Office Affiliates", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong.Please try again.", "Office Affiliates", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }


                }
            }
            catch(Exception)
            {
                MessageBox.Show("Something went wrong.Please try again.", "Office Affiliates", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void btn_Exit_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Downlods the file.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void DownlodFile(object sender, RoutedEventArgs e)
        {
            try
            {
                //Get the selected project from listbox
                Project_Table project = (Project_Table)My_Data_List.SelectedItem;

                //call the service and get downloading fie 
                byte[] downloadFie = Ref.DownloadDocument(project.Proj_Id);

                if (downloadFie != null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();

                    //set default filter and saving file type
                    saveFileDialog.Filter = "Word Files | *.docx";
                    saveFileDialog.DefaultExt = "docx";
                    if (saveFileDialog.ShowDialog() == true)
                    {
                        //save file 
                        File.WriteAllBytes(saveFileDialog.FileName, downloadFie);
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
                MessageBox.Show("Something went wrong.Please try again.", "Office Affiliates", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ListSelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }
    }
}
