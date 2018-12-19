using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_itp_sa //sa=service application
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        Data1DataContext DB = new Data1DataContext();

        /*---------------------------------------------------------------------------------------------------------*/

        //get current month Projects --To--> Project Window  --------------------------------------------(D.M.R.S.Dissanayake)
        public List<Project_Table> get_ProjectsItems_By_Month(int month)
        {
            var result = (from a in DB.Project_Tables
                          where a.Proj_Sdate.Month == month
                          select a);
            return result.ToList();
        }
        /*---------------------------------------------------------------------------------------------------------*/





        //get completed or ongoing Projects --To--> Project Window  -------------------------------------(D.M.R.S.Dissanayake)
        public List<Project_Table> get_ProjectsItems_By_Status(String Status)
        {
            var list = (from a in DB.Project_Tables
                        where a.Proj_Status == Status
                        select a);

            return list.ToList();
        }
        /*---------------------------------------------------------------------------------------------------------*/







        //get All Projects --To--> Project Window  -----------------------------------------------------(D.M.R.S.Dissanayake)
        public List<Project_Table> get_All_ProjectsItems()
        {
            var list = (from a in DB.Project_Tables
                        select a);

            return list.ToList();
        }
        /*---------------------------------------------------------------------------------------------------------*/








        //get employee list(Sorted List) --To--> Employee Window   ---------------------------------------(D.M.R.S.Dissanayake)
        public List<Project_Table> get_All_EmpWindowItems(String id)
        {
            try
            {

                String emp = (from a in DB.Employee_Tables
                              where a.Emp_Id == id
                              select a.Emp_Name).First();

                var result = (from a in DB.Project_Tables
                              where a.Emp_Name == emp
                              select a);

                return result.ToList();

            }
            catch (Exception)
            {
                return null;
            }
        }
        /*---------------------------------------------------------------------------------------------------------*/







        //get employee list --To--> Employee stats Window   ----------------------------------------------(D.M.R.S.Dissanayake)
        public List<Employee_Table> get_All_EmployeeDeatils()
        {
            try
            {
                var result1 = (from a in DB.Employee_Tables
                               select a);
                return result1.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        /*---------------------------------------------------------------------------------------------------------*/






        //get password and user type --o--> Main/Login Window    ------------------------------------------(D.M.R.S.Dissanayake)
        public String Select_LogInDetails(String id)
        {
            try
            {

                String passwordAndType = (from a in DB.UserLogin_Tables
                                          where a.User_Id == id
                                          select a.Password).First();

                passwordAndType += "\u2248" + (from a in DB.UserLogin_Tables
                                               where a.User_Id == id
                                               select a.User_Type).First();

                return passwordAndType;

            }
            catch (Exception)
            {
                return null;
            }
        }
        /*---------------------------------------------------------------------------------------------------------*/







        //Insert a new project --o--> Project Window     --------------------------------------------------(D.M.R.S.Dissanayake)
        public bool Insert_Project(int id, String name, String des, DateTime sdate, DateTime edate, String ename)
        {
            bool val = false;

            try
            {
                Project_Table new_pro = new Project_Table();

                new_pro.Proj_Id = id;
                new_pro.Proj_Name = name;
                new_pro.Proj_Des = des;
                new_pro.Proj_Status = "In Progress";
                new_pro.Proj_Sdate = sdate;
                new_pro.Proj_Edate = edate;
                new_pro.Emp_Name = ename;

                DB.Project_Tables.InsertOnSubmit(new_pro);
                DB.SubmitChanges();
                val = true;

            }
            catch (Exception)
            {
                val = false;
            }
            return val;
        }
        /*---------------------------------------------------------------------------------------------------------*/







        //update exsisting project --o--> Project Window     --------------------------------------------(D.M.R.S.Dissanayake)
        public bool Update_Project(int id, String name, String des, DateTime sdate, DateTime edate, char stat, String ename)
        {
            bool val = false;

            try
            {
                var update = (from aa in DB.Project_Tables where aa.Proj_Id == id select aa).First();
                update.Proj_Name = name;
                update.Proj_Des = des;
                update.Proj_Sdate = sdate;
                update.Proj_Edate = edate;
                update.Emp_Name = ename;

                if (stat == 'O')
                    update.Proj_Status = "In Progress";
                else
                    update.Proj_Status = "Completed";

                DB.SubmitChanges();
                val = true;
            }
            catch (Exception)
            {
                val = false;
            }
            return val;
        }
        /*---------------------------------------------------------------------------------------------------------*/






        //Delete exsisting project --o--> Project Window     --------------------------------------------(D.M.R.S.Dissanayake)
        public bool Delete_Project(int id)
        {
            bool rt_val = false;
            try
            {
                var res = (from a in DB.Project_Tables
                           where a.Proj_Id == id
                           select a).First();


                DB.Project_Tables.DeleteOnSubmit(res);
                DB.SubmitChanges();
                rt_val = true;
            }
            catch (Exception)
            {
                rt_val = false;
            }

            return rt_val;
        }
        /*---------------------------------------------------------------------------------------------------------*/








        //Generate new project ID-------------------------------------------------------------------------(D.M.R.S.Dissanayake)
        public int get_next_Id()
        {
            try
            {
                int max_val = (from a in DB.Project_Tables
                               select a.Proj_Id).Max();

                return max_val + 1;
            }
            catch (Exception)
            {
                return 999;
            }
        }
        /*---------------------------------------------------------------------------------------------------------*/






        //Search from project table                           --------------------------------------------(D.M.R.S.Dissanayake)
        public List<Project_Table> search_Projects(String user_value)
        {
            var res = (from a in DB.Project_Tables
                       where a.Proj_Name.Contains(user_value) || a.Proj_Des.Contains(user_value)
                       select a);

            return res.ToList();

        }
        /*---------------------------------------------------------------------------------------------------------*/







        //update exsisting Employee --o--> Employee Stats Window [Emplpoyee table]    ________________________(V.D.B.Ganegoda )
        public bool Update_Employee_table(String id, String name, String email, String contact)
        {
            bool val = false;

            try
            {
                var updateEMP = (from aa in DB.Employee_Tables where aa.Emp_Id == id select aa).First();

                updateEMP.Emp_Name = name;
                updateEMP.Contact = contact;
                updateEMP.Email = email;


                DB.SubmitChanges();

                val = true;
            }
            catch (Exception)
            {
                val = false;
            }
            return val;
        }
        /*---------------------------------------------------------------------------------------------------------*/





        //update exsisting Employee --o--> Employee Stats Window [user log in table]    ---------------------------(V.D.B.Ganegoda)
        public bool Update_Employee_UserLogin_Table(String UID, String PSW)
        {
            bool val = false;

            try
            {
                var updateUserLogin = (from aa in DB.UserLogin_Tables where aa.User_Id == UID select aa).First();


                updateUserLogin.Password = PSW;
                updateUserLogin.User_Type = "Employee";

                DB.SubmitChanges();

                val = true;
            }
            catch (Exception)
            {
                val = false;
            }
            return val;
        }
        /*---------------------------------------------------------------------------------------------------------*/





        //Insert new Employee --o--> Employee Stats Window    ________________________(V.D.B.Ganegoda)
        public bool Insert_Employee(String id, String name, String email, String contact)
        {
            bool val = false;

            try
            {
                Employee_Table new_Emp = new Employee_Table();

                new_Emp.Emp_Id = id;
                new_Emp.Emp_Name = name;
                new_Emp.Contact = contact;
                new_Emp.Email = email;

                DB.Employee_Tables.InsertOnSubmit(new_Emp);
                DB.SubmitChanges();

                val = true;
            }
            catch (Exception)
            {
                val = false;
            }
            return val;
        }
        /*---------------------------------------------------------------------------------------------------------*/





        //Insert exsisting Employee --o--> Employee Stats Window [user log in table]    ________________________(V.D.B.Ganegoda)
        public bool Insert_Employee_UserLogin_Table(String UID, String PSW)
        {
            bool val = false;

            try
            {


                UserLogin_Table new_emp = new UserLogin_Table();

                new_emp.User_Id = UID;
                new_emp.Password = PSW;
                new_emp.User_Type = "Employee";


                DB.UserLogin_Tables.InsertOnSubmit(new_emp);
                DB.SubmitChanges();

                val = true;
            }
            catch (Exception)
            {
                val = false;
            }
            return val;
        }
        /*---------------------------------------------------------------------------------------------------------*/





        //Delete exsisting Employee --o--> employee stats Window     ________________________(V.D.B.Ganegoda)
        public bool Delete_Employee_form_Emp_table(String id)
        {
            bool rt_val = false;
            try
            {
                var del = (from a in DB.Employee_Tables
                           where a.Emp_Id == id
                           select a).First();


                DB.Employee_Tables.DeleteOnSubmit(del);
                DB.SubmitChanges();
                rt_val = true;
            }
            catch (Exception)
            {
                rt_val = false;
            }

            return rt_val;
        }
        /*---------------------------------------------------------------------------------------------------------*/





        //Delete exsisting User(Emloyee) --o--> employee stats Window     ________________________(V.D.B.Ganegoda)
        public bool Delete_Employee_form_User_Login_table(String id)
        {
            bool rt_val = false;
            try
            {
                var del = (from a in DB.UserLogin_Tables
                           where a.User_Id == id
                           select a).First();


                DB.UserLogin_Tables.DeleteOnSubmit(del);
                DB.SubmitChanges();
                rt_val = true;
            }
            catch (Exception)
            {
                rt_val = false;
            }

            return rt_val;
        }
        /*---------------------------------------------------------------------------------------------------------*/








        /*---------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Downloads the document.
        /// </summary>
        /// <param name="projectID">The project identifier.</param>
        /// <returns></returns>
        public byte[] DownloadDocument(int projectID)
        {
            //Select document from database
            Document document = (from doc in DB.Documents
                                 where doc.Proj_Id == projectID && doc.Status == "upload"
                                 select doc).FirstOrDefault();

            // Document documen = DB.Documents.Where(d => d.Proj_Id == projectID).FirstOrDefault();
            if (document != null)
            {
                //get upload file path.
                string documentPath = document.Path;

                //get byte array from document path.
                byte[] downlodingFile = File.ReadAllBytes(documentPath);
                return downlodingFile;
            }

            return null;
        }


        /// <summary>
        /// Uploads the file.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="uplodingDocument">The uploding document.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool UploadFile(int projectId, string fileName, byte[] uplodingDocument)
        {
            try
            {
                //generate saving path.
                string uploadingPath = Path.Combine(@"D:\BSC IN IT\2 nd year\2nd semester\ITP\UploadDocuments", fileName);

                //get filename without extention
                fileName = Path.GetFileNameWithoutExtension(fileName);

                // Get document from database
                Document document = (from doc in DB.Documents
                                     where doc.Proj_Id == projectId && doc.Status == "completed"
                                     select doc).FirstOrDefault();
                if (document == null)
                {
                    //create new document
                    document = new Document
                    {
                        Doc_Name = fileName,
                        Path = uploadingPath,
                        Proj_Id = projectId,
                        Status = "completed"
                    };

                    //add new document to database
                    DB.Documents.InsertOnSubmit(document);
                }
                else
                {
                    //update existing document.
                    document.Doc_Name = fileName;
                    document.Path = uploadingPath;
                }

                //Update database
                DB.SubmitChanges();

                //save file to folder.
                File.WriteAllBytes(uploadingPath, uplodingDocument);

                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }






        public byte[] DownloadCompleteDocument(int projectID)
        {
            Document completedocument = (from doc in DB.Documents
                                         where doc.Proj_Id == projectID && doc.Status == "completed"
                                         select doc).FirstOrDefault();



            if (completedocument != null)
            {
                //get upload file path.
                string completeddocumentPath = completedocument.Path;

                //get byte array from document path.
                byte[] downlodingFile = File.ReadAllBytes(completeddocumentPath);
                return downlodingFile;
            }

            return null;


        }

        public bool UploadAdminFile(int projectId, string fileName, byte[] uplodingDocument)
        {
            try
            {
                //generate saving path.
                string uploadingPath = Path.Combine(@"D:\BSC IN IT\2 nd year\2nd semester\ITP\UploadDocuments", fileName);

                //get filename without extention
                fileName = Path.GetFileNameWithoutExtension(fileName);

                // Get document from database
                Document document = (from doc in DB.Documents
                                     where doc.Proj_Id == projectId && doc.Status == "completed"
                                     select doc).First();
                if (document == null)
                {
                    //create new document
                    document = new Document
                    {
                        Doc_Name = fileName,
                        Path = uploadingPath,
                        Proj_Id = projectId,
                        Status = "completed"
                    };

                    //add new document to database
                    DB.Documents.InsertOnSubmit(document);
                }
                else
                {
                    //update existing document.
                    document.Doc_Name = fileName;
                    document.Path = uploadingPath;
                }

                //Update database
                DB.SubmitChanges();

                //save file to folder.
                File.WriteAllBytes(uploadingPath, uplodingDocument);

                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }


    }
}

