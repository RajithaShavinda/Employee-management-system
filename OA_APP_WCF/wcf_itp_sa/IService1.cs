using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_itp_sa
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        /*----------------------------------------------D.M.R.S.Dissanayake----------------------------------------------*/
        [OperationContract]
        List<Project_Table> get_ProjectsItems_By_Month(int month);

        [OperationContract]
        List<Project_Table> get_ProjectsItems_By_Status(String Status);

        [OperationContract]
        List<Project_Table> get_All_ProjectsItems();

        [OperationContract]
        List<Employee_Table> get_All_EmployeeDeatils();

        [OperationContract]
        String Select_LogInDetails(String id);


        [OperationContract]
        List<Project_Table> get_All_EmpWindowItems(String emp);


        [OperationContract]
        bool Insert_Project(int id, String name, String des, DateTime sdate, DateTime edate, String ename);

        [OperationContract]
        bool Update_Project(int id, String name, String des, DateTime sdate, DateTime edate, char stat, String ename);


        [OperationContract]
        bool Delete_Project(int id);


        [OperationContract]
        List<Project_Table> search_Projects(String user_value);

        [OperationContract]
        int get_next_Id();


        /*----------------------------------------------V.D.B.Ganegoda----------------------------------------------*/
        [OperationContract]
        bool Update_Employee_table(String id, String name, String email, String contact);

        [OperationContract]
        bool Update_Employee_UserLogin_Table(String UID, String PSW);

        [OperationContract]
        bool Insert_Employee(String id, String name, String email, String contact);

        [OperationContract]
        bool Insert_Employee_UserLogin_Table(String UID, String PSW);

        [OperationContract]
        bool Delete_Employee_form_Emp_table(String id);

        [OperationContract]
        bool Delete_Employee_form_User_Login_table(String id);
        /// <summary>
        /// Downloads the document.
        /// </summary>
        /// <param name="projectID">The project identifier.</param>
        /// <returns></returns>
        [OperationContract]
        byte[] DownloadDocument(int projectID);

        [OperationContract]
        bool UploadFile(int projectId, string fileName, byte[] uplodingDocument);



        [OperationContract]
        byte[] DownloadCompleteDocument(int projectID);

        [OperationContract]
        bool UploadAdminFile(int projectId, string fileName, byte[] uplodingDocument);



    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.

}
