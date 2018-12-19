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
    /// Interaction logic for Project_Window.xaml
    /// </summary>
    public partial class Project_Window : Window
    {
        SRef.Service1Client Ref = new Service1Client();




        public Project_Window()
        {
            InitializeComponent();
            load_combo_Box();
            LoadProjects();
        }

        void load_combo_Box()
        {
            cboGetMonth.Items.Add("January");
            cboGetMonth.Items.Add("February");
            cboGetMonth.Items.Add("March");
            cboGetMonth.Items.Add("April");
            cboGetMonth.Items.Add("May");
            cboGetMonth.Items.Add("June");
            cboGetMonth.Items.Add("July");
            cboGetMonth.Items.Add("August");
            cboGetMonth.Items.Add("September");
            cboGetMonth.Items.Add("October");
            cboGetMonth.Items.Add("November");
            cboGetMonth.Items.Add("December");

        }

        void LoadProjects()
        {
            try
            {

                int Month = DateTime.Now.Month;



                My_Data_List.ItemsSource = Ref.get_ProjectsItems_By_Month(Month);
            }
            catch (Exception)
            {
                MessageBox.Show("Network Connection Error", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        private void btn_Emp_stats_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Employee_Stats_Window AP = new Employee_Stats_Window();
                AP.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Network Connection Error", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btn_Exit_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void btn_Add_Project_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int projectId = 0;
                projectId = Ref.get_next_Id();

                Add_Project AP = new Add_Project(projectId, "", "", "", "", "", 'O', 'N');
                AP.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Network Connection Error", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

        private void btn_View_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Project_Table Selected_Item = (Project_Table)My_Data_List.SelectedItem;

                Detail_Window DW = new Detail_Window(Selected_Item);
                DW.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a project before click the view button", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }



        private void cboGetMonth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int index = cboGetMonth.SelectedIndex;

                My_Data_List.ItemsSource = Ref.get_ProjectsItems_By_Month(++index);
            }
            catch (Exception)
            {
                MessageBox.Show("Network Connection Error", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

        private void btnSearch_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                My_Data_List.ItemsSource = Ref.search_Projects(txtSearch.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Network Connection Error", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            My_Data_List.ItemsSource = Ref.get_ProjectsItems_By_Status("Completed");
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            My_Data_List.ItemsSource = Ref.get_ProjectsItems_By_Status("In Progress");
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            My_Data_List.ItemsSource = Ref.get_All_ProjectsItems();
        }

        private void txtSearch_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                try
                {
                    My_Data_List.ItemsSource = Ref.search_Projects(txtSearch.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Network Connection Error", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }

        }
    
    }
}
