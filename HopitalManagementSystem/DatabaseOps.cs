using HospitalManagementSystem.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HopitalManagementSystem
{
    public class DatabaseOps : IDatabaseOps
    {
        private IDatabaseOps _databaseOps;
        private readonly IServiceProvider serviceProvider;
        public static bool isDoctorLogin = true;
        public static int ID = 0;
        public static string connectionString = @"Data Source=(local);Initial Catalog=HMS;Integrated Security=True;";
        internal SqlConnection sqlConnection;        internal SqlDataAdapter sqlDataAdapter;
        internal SqlCommand sqlCommand;
        public DatabaseOps(IServiceProvider serviceProvider)
        {
            sqlConnection = new SqlConnection(connectionString);
            this.serviceProvider = serviceProvider;
        }
        public DatabaseOps()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public DataTable timeslotlist(int docid)
        {
            DataTable dataTable = new DataTable();
            try
            {
                sqlConnection.Open();
                string query = "SELECT id, Concat(slotstart, ' ', slotend) AS slotdec FROM timeSlots WHERE slotdocid = @docid AND isavailable = 1";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@docid", docid);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(dataTable);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }

            return dataTable;
        }

        public DataTable GetAppointmentofDoctor(int docid)
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter(@"select slotstart as Start_Timings,slotend as End_Timings,CHECKUP_DATE,PATIENTS.PAT_NAME,DOCTORS.DOC_NAME from APPOINTMENT inner join timeSlots on timeSlots.id =Slot_ID
inner join DOCTORS on DOCTORS.ID = DOC_CODE
inner join PATIENTS on PATIENTS.ID = PAT_CODE
where APPOINTMENT.DOC_CODE = " + docid + "", sqlConnection);

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable GetAppointmentofDoctor(int docid, string by)
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter(@"select slotstart as Start_Timings,slotend as End_Timings,CHECKUP_DATE,PATIENTS.PAT_NAME,DOCTORS.DOC_NAME from APPOINTMENT inner join timeSlots on timeSlots.id =Slot_ID
inner join DOCTORS on DOCTORS.ID = DOC_CODE
inner join PATIENTS on PATIENTS.ID = PAT_CODE
where APPOINTMENT.DOC_CODE = " + docid + "and CHECKUP_DATE ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'", sqlConnection);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public int gettimeslotidfromappointment(string apid)
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("select Slot_ID from APPOINTMENT where AID = '" + apid + "'", sqlConnection);

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return Convert.ToInt32(dataTable.Rows[0][0].ToString());
        }
        public void updatetimeslotavailability(int id, int yesorno)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("UPDATE timeSlots SET isavailable = @yesorno WHERE id = @DID", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@DID", id);
                sqlCommand.Parameters.AddWithValue("@yesorno", yesorno);

                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to updated Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update(Doctor doctor, string DoctorLogin)
        {
            try
            {
                //int id = GetIDbyName("Department", doctor.Department, "DepartmentName", "ID");
                //int rid = GetIDbyName("DoctorRoles", doctor.Designation, "Rolename", "ID");
                sqlConnection.Open();
                string hashedPassword = HashPassword(doctor.Password);
                sqlCommand = new SqlCommand("UPDATE DOCTORS SET DOC_NAME = @NAME, DOC_GENDER = @GENDER, DOC_ADDRESS = @ADDRESS,DOC_PASS =@pass, DOC_tel = @TEL, DOC_Role_ID  = @DESIG, DOC_DEP_ID = @DEPART, DOC_EMAIL = @EMAIL ,PricePerAppointment = @ppa WHERE DOC_ID = @DID", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@DID", doctor.ID);
                sqlCommand.Parameters.AddWithValue("@NAME", doctor.Name);
                sqlCommand.Parameters.AddWithValue("@GENDER", doctor.Gender);
                sqlCommand.Parameters.AddWithValue("@pass", hashedPassword);
                sqlCommand.Parameters.AddWithValue("@ADDRESS", doctor.Address);
                sqlCommand.Parameters.AddWithValue("@TEL", doctor.Tel);
                sqlCommand.Parameters.AddWithValue("@DESIG", int.Parse(doctor.Designation));
                sqlCommand.Parameters.AddWithValue("@EMAIL", doctor.Email);
                sqlCommand.Parameters.AddWithValue("@DEPART", int.Parse(doctor.Department));
                //sqlCommand.Parameters.AddWithValue("@st", doctor.starttime);
                //sqlCommand.Parameters.AddWithValue("@et", doctor.endtime);
                sqlCommand.Parameters.AddWithValue("@ppa", doctor.PricePerAppointment);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Data Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to updated Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update(Doctor doctor)
        {
            try
            {
                int id = GetIDbyName("Department", doctor.Department, "DepartmentName", "ID");
                int rid = GetIDbyName("DoctorRoles", doctor.Designation, "Rolename", "ID");
                sqlConnection.Open();
                string hashedPassword = HashPassword("123");
                sqlCommand = new SqlCommand("UPDATE DOCTORS SET DOC_NAME = @NAME, DOC_GENDER = @GENDER, DOC_ADDRESS = @ADDRESS,DOC_PASS =@pass, DOC_tel = @TEL, DOC_Role_ID  = @DESIG, DOC_DEP_ID = @DEPART, DOC_EMAIL = @EMAIL ,PricePerAppointment = @ppa WHERE DOC_ID = @DID", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@DID", doctor.ID);
                sqlCommand.Parameters.AddWithValue("@NAME", doctor.Name);
                sqlCommand.Parameters.AddWithValue("@GENDER", doctor.Gender);
                sqlCommand.Parameters.AddWithValue("@pass", hashedPassword);
                sqlCommand.Parameters.AddWithValue("@ADDRESS", doctor.Address);
                sqlCommand.Parameters.AddWithValue("@TEL", doctor.Tel);
                sqlCommand.Parameters.AddWithValue("@DESIG", rid);
                sqlCommand.Parameters.AddWithValue("@EMAIL", doctor.Email);
                sqlCommand.Parameters.AddWithValue("@DEPART", id);
                sqlCommand.Parameters.AddWithValue("@st", doctor.starttime);
                sqlCommand.Parameters.AddWithValue("@et", doctor.endtime);
                sqlCommand.Parameters.AddWithValue("@ppa", doctor.PricePerAppointment);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    sqlConnection.Close();
                    insertavailability(doctor);
                }
                else
                {
                    MessageBox.Show("Unable to update Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void update(Appointment appointment)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("UPDATE APPOINTMENT SET CHECKUP_DATE = @date, Slot_ID = @timeslotid, PAT_CODE= @patientid, DOC_CODE=@docid  where AID = @id", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@id", appointment.AppointmentID);
                sqlCommand.Parameters.AddWithValue("@date", appointment.AppointmentDate);
                sqlCommand.Parameters.AddWithValue("@timeslotid", appointment.TimeslotID);
                sqlCommand.Parameters.AddWithValue("@patientid", appointment.PatientID);
                sqlCommand.Parameters.AddWithValue("@docid", appointment.DoctorID);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to updated Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void insert(Appointment appointment)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("INSERT INTO APPOINTMENT VALUES (@date, @timeslotid, @patientid, @docid)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@date", appointment.AppointmentDate);
            sqlCommand.Parameters.AddWithValue("@timeslotid", appointment.TimeslotID);
            sqlCommand.Parameters.AddWithValue("@patientid", appointment.PatientID);
            sqlCommand.Parameters.AddWithValue("@docid", appointment.DoctorID);
            int a = sqlCommand.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Appointed Successfully", "Appointed", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Data not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
        }
        public void insert(Doctor doctor)
        {
            try
            {
                int id = GetIDbyName("Department", doctor.Department, "DepartmentName", "ID");
                int rid = GetIDbyName("DoctorRoles", doctor.Designation, "Rolename", "ID");
                sqlConnection.Open();
                string pass = "123";
                string hashedPassword = HashPassword(pass);
                sqlCommand = new SqlCommand("INSERT INTO DOCTORS(DOC_NAME, DOC_DEP_ID, DOC_TEL, DOC_EMAIL, DOC_PASS, DOC_GENDER, DOC_ADDRESS, DOC_Role_ID,PricePerAppointment) VALUES (@name, @depart, @tel, @email, @pass, @gender, @address, @desig,@ppa)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@name", doctor.Name);
                sqlCommand.Parameters.AddWithValue("@depart", id);
                sqlCommand.Parameters.AddWithValue("@tel", doctor.Tel);
                sqlCommand.Parameters.AddWithValue("@email", doctor.Email);
                sqlCommand.Parameters.AddWithValue("@pass", hashedPassword);
                sqlCommand.Parameters.AddWithValue("@gender", doctor.Gender);
                sqlCommand.Parameters.AddWithValue("@address", doctor.Address);
                sqlCommand.Parameters.AddWithValue("@desig", rid);
                sqlCommand.Parameters.AddWithValue("@ppa", doctor.PricePerAppointment);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    sqlConnection.Close();
                    insertavailability(doctor);
                }

                else
                {
                    MessageBox.Show("Data not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void insertavailability(Doctor doctor)
        {
            int docid = GetIDbyName("DOCTORS", doctor.Email, "DOC_EMAIL", "ID");
            sqlConnection.Open();
            sqlCommand = new SqlCommand("createAvailability", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@AvailabilityId", 1);
            sqlCommand.Parameters.AddWithValue("@SlotStart", doctor.starttime);
            sqlCommand.Parameters.AddWithValue("@SlotEnd", doctor.endtime);
            sqlCommand.Parameters.AddWithValue("@SlotDoctorId", docid);

            int b = sqlCommand.ExecuteNonQuery();

            if (b > 0)
            {
                MessageBox.Show("Registered Successfully", "Registered", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error in Creating Doctor Availability", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int GetIDbyName(string tablename, string name, string colname, string returnColName)
        {
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tablename + " where " + colname + "=" + "'" + name + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return Convert.ToInt32(dataTable.Rows[0][returnColName].ToString());
        }

        public string HashPassword(string password)
        {
            // Example: Using SHA256 hashing
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        public void insert(Employee employee)
        {
            int id = GetIDbyName("Department", employee.Department, "DepartmentName", "ID");
            int rid = GetIDbyName("EmployeeRoles", employee.Designation, "RoleName", "ID");

            if (!employee.Email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Invalid email format. Must end with @gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsPasswordValid(employee.Pass))
            {
                MessageBox.Show("Invalid password format. It must be at least 6 characters long and include digits, special characters, uppercase and lowercase letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                sqlConnection.Open();
                string hashedPassword = HashPassword(employee.Pass);
                sqlCommand = new SqlCommand("INSERT INTO Employee(EMP_NAME, EMP_GENDER, EMP_PASS, DepartmentID, EMP_TEL, EMP_EMAIL, EMP_ADDRESS, RoleID) " +
                                    "VALUES (@NAME, @GENDER, '" + hashedPassword + "', @DEPART, @TEL, @EMAIL, @ADDRESS, @ROLE)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@NAME", employee.Name);
                sqlCommand.Parameters.AddWithValue("@GENDER", employee.Gender);
                sqlCommand.Parameters.AddWithValue("@PASS", employee.Pass);
                sqlCommand.Parameters.AddWithValue("@DEPART", id);
                sqlCommand.Parameters.AddWithValue("@TEL", employee.Tel);
                sqlCommand.Parameters.AddWithValue("@EMAIL", employee.Email);

                sqlCommand.Parameters.AddWithValue("@ADDRESS", employee.Address);

                sqlCommand.Parameters.AddWithValue("@ROLE", rid);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Registered Successfully", "Registered", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsPasswordValid(string password)
        {
            // Password complexity rules
            if (password.Length < 6)
            {
                return false;
            }

            if (!Regex.IsMatch(password, @"\d"))
            {
                return false;
            }

            if (!Regex.IsMatch(password, @"[!@#$%^&*]"))
            {
                return false;
            }


            if (!Regex.IsMatch(password, @"[a-z]") || !Regex.IsMatch(password, @"[A-Z]"))
            {
                return false;
            }

            return true;

        }
        public void insert(Patient patient)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("INSERT INTO PATIENTS(PAT_NAME, PAT_TEL, PAT_EMAIL, PAT_GENDER, PAT_ADDRESS, Createdby,PAT_DATE) VALUES (@name, @tel, @email, @gender, @address, @doc,@date)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@name", patient.Name);
                sqlCommand.Parameters.AddWithValue("@tel", patient.Tel);
                sqlCommand.Parameters.AddWithValue("@email", patient.Email);
                sqlCommand.Parameters.AddWithValue("@gender", patient.Gender);
                sqlCommand.Parameters.AddWithValue("@address", patient.Address);
                sqlCommand.Parameters.AddWithValue("@doc", patient.CreatedBy);
                sqlCommand.Parameters.AddWithValue("@date", patient.Date);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Registered Successfully", "Registered", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void insert(Room room)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("INSERT INTO ROOM(ROOM_NO, FLOOR_NO, ROOM_STATUS, ROOM_TYPE, PRICE_PER_DAY) VALUES (@ROOM_NO, @FLOOR_NO, @ROOM_STATUS, @ROOM_TYPE, @PRICE_PER_HOUR)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ROOM_NO", room.Room_No);
                sqlCommand.Parameters.AddWithValue("@FLOOR_NO", room.Floor_No);
                sqlCommand.Parameters.AddWithValue("@ROOM_STATUS", room.Room_status);
                sqlCommand.Parameters.AddWithValue("@ROOM_TYPE", room.Room_type);
                sqlCommand.Parameters.AddWithValue("@PRICE_PER_HOUR", room.Price_Per_Day);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Registered Successfully", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void insert(Inpatient inpatient)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("INSERT INTO INPATIENT(DATE_OF_AD, DATE_OF_DIS, PAT_CODE,ROOM_CODE,TotalAmount) VALUES (@DATE_OF_AD, @DATE_OF_DIS, @PAT_CODE, @ROOM_CODE,@ta)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@DATE_OF_AD", inpatient.Admission);
                sqlCommand.Parameters.AddWithValue("@DATE_OF_DIS", inpatient.Discharge);
                sqlCommand.Parameters.AddWithValue("@PAT_CODE", inpatient.PatID);
                sqlCommand.Parameters.AddWithValue("@ROOM_CODE", inpatient.RoomNo);
                sqlCommand.Parameters.AddWithValue("@ta", inpatient.TotalAmount);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Registered Successfully", "Registered", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //public void insert(OutPatient outPatient)
        //{
        //    try
        //    {
        //        sqlConnection.Open();
        //        sqlCommand = new SqlCommand("INSERT INTO APPOINTMENT(CHECKUP_DATE, START_TIME, END_TIME, PAT_CODE) VALUES (@CHECK_UP_DATE, @START_TIME, @END_TIME, @PAT_CODE)", sqlConnection);
        //        sqlCommand.Parameters.AddWithValue("@CHECK_UP_DATE", outPatient.Date_Of_Appointment);
        //        sqlCommand.Parameters.AddWithValue("@START_TIME", outPatient.Start_Time_of_Appointment);
        //        sqlCommand.Parameters.AddWithValue("@END_TIME", outPatient.End_Time_of_Appointment);
        //        sqlCommand.Parameters.AddWithValue("@PAT_CODE", outPatient.PatID);
        //        int a = sqlCommand.ExecuteNonQuery();
        //        if (a > 0)
        //        {
        //            MessageBox.Show("Appointment Booked Successfully", "Registered", MessageBoxButtons.OK,
        //            MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Data not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        sqlConnection.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        public void update(Patient patient)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("UPDATE PATIENTS SET PAT_NAME = @name, PAT_TEL = @tel, PAT_EMAIL= @email, PAT_GENDER=@gender, PAT_ADDRESS=@address, Createdby=@doc,PAT_DATE = @date where PAT_ID = @pid", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@name", patient.Name);
                sqlCommand.Parameters.AddWithValue("@tel", patient.Tel);
                sqlCommand.Parameters.AddWithValue("@email", patient.Email);
                sqlCommand.Parameters.AddWithValue("@gender", patient.Gender);
                sqlCommand.Parameters.AddWithValue("@address", patient.Address);
                sqlCommand.Parameters.AddWithValue("@doc", patient.CreatedBy);
                sqlCommand.Parameters.AddWithValue("@date", patient.Date);
                sqlCommand.Parameters.AddWithValue("@pid", patient.ID);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to updated Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update(Inpatient inpatient)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("UPDATE INPATIENT SET DATE_OF_AD = @DATE_OF_AD, DATE_OF_DIS = @DATE_OF_DIS, ROOM_CODE = @ROOM_CODE, PAT_CODE = @PAT_CODE , TotalAmount =@ta WHERE ID = @INPATID", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@DATE_OF_AD", inpatient.Admission);
                sqlCommand.Parameters.AddWithValue("@DATE_OF_DIS", inpatient.Discharge);
                sqlCommand.Parameters.AddWithValue("@ROOM_CODE", inpatient.RoomNo);
                sqlCommand.Parameters.AddWithValue("@PAT_CODE", inpatient.PatID);
                sqlCommand.Parameters.AddWithValue("@INPATID", inpatient.InPatID);
                sqlCommand.Parameters.AddWithValue("@ta", inpatient.TotalAmount);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to updated Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //public void update(OutPatient outPatient)
        //{
        //    try
        //    {
        //        sqlConnection.Open();
        //        sqlCommand = new SqlCommand("UPDATE APPOINTMENT SET CHECKUP_DATE = @CHECKUP_DATE, START_TIME = @START_TIME, END_TIME = @END_TIME, PAT_CODE = @PAT_CODE WHERE AID = @AID)", sqlConnection);
        //        sqlCommand.Parameters.AddWithValue("@CHECK_UP_DATE", outPatient.Date_Of_Appointment);
        //        sqlCommand.Parameters.AddWithValue("@START_TIME", outPatient.Start_Time_of_Appointment);
        //        sqlCommand.Parameters.AddWithValue("@END_TIME", outPatient.End_Time_of_Appointment);
        //        sqlCommand.Parameters.AddWithValue("@PAT_CODE", outPatient.PatID);
        //        sqlCommand.Parameters.AddWithValue("@AID", outPatient.AID);
        //        int a = sqlCommand.ExecuteNonQuery();
        //        if (a > 0)
        //        {
        //            MessageBox.Show("Data Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Unable to updated Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        sqlConnection.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        public void makeslotsavailable()
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("makeslotsavailable", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@dateof", DateTime.Now.ToString("yyyy-MM-dd"));
                sqlCommand.ExecuteNonQuery();

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update(Employee employee)
        {
            int id = GetIDbyName("Department", employee.Department, "DepartmentName", "ID");
            int rid = GetIDbyName("EmployeeRoles", employee.Designation, "RoleName", "ID");
            string hashedPassword = HashPassword(employee.Pass);
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Update Employee set EMP_NAME= @NAME, EMP_GENDER=@GENDER, EMP_PASS=@PASS, DepartmentID=@DEPART, EMP_TEL=@TEL, EMP_EMAIL=@EMAIL, EMP_ADDRESS=@ADDRESS, RoleID=@ROLE where EMP_ID= @eid", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@eid", employee.ID);
                sqlCommand.Parameters.AddWithValue("@NAME", employee.Name);
                sqlCommand.Parameters.AddWithValue("@GENDER", employee.Gender);
                sqlCommand.Parameters.AddWithValue("@PASS", hashedPassword);
                sqlCommand.Parameters.AddWithValue("@DEPART", id);
                sqlCommand.Parameters.AddWithValue("@TEL", employee.Tel);
                sqlCommand.Parameters.AddWithValue("@EMAIL", employee.Email);
                sqlCommand.Parameters.AddWithValue("@ADDRESS", employee.Address);
                sqlCommand.Parameters.AddWithValue("@ROLE", rid);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to updated Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updateRoomAvailability(int id, string status)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("UPDATE ROOM set ROOM_STATUS = '" + status + "'  WHERE ROOM_NO = @ROOM_NO", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ROOM_NO", id);

                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Room Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to update Room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update(Room room)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("UPDATE ROOM SET FLOOR_NO = @FLOOR_NO, ROOM_STATUS = @ROOM_STATUS, ROOM_TYPE = @ROOM_TYPE, PRICE_PER_DAY = @PRICE_PER_HOUR WHERE ROOM_NO = @ROOM_NO", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ROOM_NO", room.Room_No);
                sqlCommand.Parameters.AddWithValue("@FLOOR_NO", room.Floor_No);
                sqlCommand.Parameters.AddWithValue("@ROOM_STATUS", room.Room_status);
                sqlCommand.Parameters.AddWithValue("@ROOM_TYPE", room.Room_type);
                sqlCommand.Parameters.AddWithValue("@PRICE_PER_HOUR", room.Price_Per_Day);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to updated Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteTimeSlots(int id)
        {
            
            string connectionString = @"Data Source=(local);Initial Catalog=HMS;Integrated Security=True;";

            using (var dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();  // Open the database connection

                // Create a command to delete from the APPOINTMENT table first
                using (var deleteAppointmentsCommand = new SqlCommand("DELETE FROM APPOINTMENT WHERE Doc_Code = @sdi", dbConnection))
                {
                    deleteAppointmentsCommand.Parameters.AddWithValue("@sdi", id);

                    // Execute the command to delete related appointments
                    deleteAppointmentsCommand.ExecuteNonQuery();
                }

                // Create a command to delete from the Availability table
                using (var deleteAvailabilityCommand = new SqlCommand("DELETE FROM Availability WHERE slotdocid = @sdi", dbConnection))
                {
                    deleteAvailabilityCommand.Parameters.AddWithValue("@sdi", id);
                    // Execute the command to delete related availability
                    deleteAvailabilityCommand.ExecuteNonQuery();
                }

                // Create a command to delete from the Slot table
                using (var deleteSlotsCommand = new SqlCommand("DELETE FROM timeSlots WHERE slotdocid = @sdi", dbConnection))
                {
                    deleteSlotsCommand.Parameters.AddWithValue("@sdi", id);

                    // Execute the command to delete the time slot
                    deleteSlotsCommand.ExecuteNonQuery();
                }
            }
        }

        public void delete(string tableValue, string id)
        {
            try
            {
                sqlConnection.Open();
                if (tableValue == "DOCTORS")
                {
                    sqlCommand = new SqlCommand("DELETE FROM " + tableValue + " WHERE DOC_ID = @DID",
                    sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@DID", id);
                }
                else if (tableValue == "PATIENTS")
                {
                    sqlCommand = new SqlCommand("DELETE FROM " + tableValue + " WHERE PAT_ID = @PID",
                    sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@PID", id);
                }

                else if (tableValue == "APPOINTMENT")
                {
                    sqlCommand = new SqlCommand("DELETE FROM " + tableValue + " WHERE AID = @PID",
                    sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@PID", id);
                }
                else if (tableValue == "EMPLOYEE")
                {
                    sqlCommand = new SqlCommand("DELETE FROM " + tableValue + " WHERE EMP_ID = @EID",
                    sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@EID", id);
                }
                else if (tableValue == "ROOM")
                {
                    sqlCommand = new SqlCommand("DELETE FROM " + tableValue + " WHERE ID = @RID",
                    sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@RID", id);
                }
                else if (tableValue == "APPOINTMET")
                {
                    sqlCommand = new SqlCommand("DELETE FROM " + tableValue + " WHERE ROOM_NO = @RID",
                    sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@RID", id);
                }
                else if (tableValue == "INPATIENT")
                {
                    sqlCommand = new SqlCommand("DELETE FROM " + tableValue + " WHERE ID = @INPATID",
                    sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@INPATID", id);
                }
                sqlCommand.ExecuteNonQuery();
                int a = sqlCommand.ExecuteNonQuery();
                if (a == 0)
                {
                    MessageBox.Show("Data Deleted Successfully", "Deleted", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to delete Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable display(string value)
        {
            try
            {
                sqlConnection.Open();
                //if (value == "PATIENTS")
                //{
                //    sqlDataAdapter = new SqlDataAdapter("SELECT PATIENTS.ID, PAT_NAME, DOC_NAME, PAT_GENDER, PAT_TEL, PAT_EMAIL, PAT_ADDRESS, DOC_DESIG, DOC_DEPART FROM PATIENTS INNER JOIN DOCTORS ON DOC_CODE=DOCTORS.ID", sqlConnection);
                //}
                /*else */
                if (value == "DOCTORS")
                {
                    sqlDataAdapter = new SqlDataAdapter(@"SELECT Doctors.ID,Doctors.DOC_ID,Doctors.DOC_NAME,Department.DepartmentName,Doctors.DOC_TEL,Doctors.DOC_EMAIL,Doctors.DOC_GENDER,Doctors.DOC_ADDRESS,DoctorRoles.Rolename,DOCTORS.PricePerAppointment from Doctors 
                                                        inner join Department on Department.ID = Doctors.DOC_DEP_ID
                                                        inner join DoctorRoles on DoctorRoles.ID = Doctors.DOC_Role_ID", sqlConnection);

                }
                else if (value == "EMPLOYEE")
                {
                    sqlDataAdapter = new SqlDataAdapter("select EMPLOYEE.ID,EMPLOYEE.EMP_ID,EMPLOYEE.EMP_NAME,EMPLOYEE.EMP_GENDER,EMPLOYEE.EMP_PASS,Department.DepartmentName,EMPLOYEE.EMP_TEL,EMPLOYEE.EMP_EMAIL,EMPLOYEE.EMP_ADDRESS,EmployeeRoles.RoleName from Employee " +
                        "inner join Department on EMPLOYEE.DepartmentID = Department.ID " +
                        "inner join EmployeeRoles on EMPLOYEE.RoleID = EmployeeRoles.ID", sqlConnection);

                }

                else
                {
                    sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + value + "", sqlConnection);
                }
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show("Enter valid Employee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable displayInPat()
        {
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter("SELECT INPATIENT.ID, PATIENTS.ID As Patient_ID, PAT_NAME, PAT_TEL, DATE_OF_AD, DATE_OF_DIS, ROOM.ID AS ROOM_NUMBER, ROOM_TYPE, TotalAmount FROM INPATIENT INNER JOIN PATIENTS ON PATIENTS.ID = PAT_CODE INNER JOIN ROOM ON ROOM.ID = ROOM_CODE", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable displayAppointment(string Id)
        {
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter("SELECT AID, PAT_NAME, PAT_TEL, DOC_NAME, CHECKUP_DATE , START_TIME, END_TIME, PAT_CODE, DOC_CODE FROM APPOINTMENT INNER JOIN PATIENTS ON PATIENTS.ID = PAT_CODE INNER JOIN DOCTORS ON DOCTORS.ID = PATIENTS.DOC_CODE", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable doctorAppointment()
        {
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter("select AID,DOC_NAME,PAT_NAME,CHECKUP_DATE,slotstart,slotend,DOCTORS.PricePerAppointment from APPOINTMENT inner join timeSlots on APPOINTMENT.Slot_ID = timeSlots.id inner join PATIENTS on APPOINTMENT.PAT_CODE = PATIENTS.ID inner join DOCTORS on DOCTORS.ID = APPOINTMENT.DOC_CODE", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable display()
        {
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM WHERE ROOM_STATUS = 'AVAILABLE'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public void Showincbx(ComboBox cbx, string tablename, string colname)
        {
            cbx.Items.Clear();
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tablename, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                cbx.Items.Add(dataTable.Rows[i][colname]);
            }
        }



        public DataTable search(string tableValue, string searchValue, string searchByValue)
        {
            try
            {
                sqlConnection.Open();
                if (tableValue == "DOCTORS")
                {
                    if (searchByValue.ToLower() == "doctor id")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tableValue + " WHERE DOC_ID LIKE '%" + searchValue + "%'", sqlConnection);
                    }
                    else if (searchByValue.ToLower() == "number")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tableValue + " WHERE DOC_TEL LIKE '%" + searchValue + "%'", sqlConnection);
                    }

                    else
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tableValue + " WHERE DOC_NAME LIKE '%" + searchValue + "%'", sqlConnection);
                    }
                }
                else if (tableValue == "PATIENTS")
                {
                    if (searchByValue.ToLower() == "patient name")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT * FROM PATIENTS WHERE PAT_NAME LIKE '%" + searchValue + "%'", sqlConnection);
                    }

                    else if (searchByValue.ToLower() == "patient number")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT * FROM PATIENTS WHERE PAT_TEL LIKE '%" + searchValue + "%'", sqlConnection);
                    }

                    else
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT * FROM PATIENTS WHERE PAT_ID LIKE '%" + searchValue + "%'", sqlConnection);
                    }
                }

                else if (tableValue == "EMPLOYEE")
                {
                    if (searchByValue.ToLower() == "name")
                    {
                        sqlDataAdapter = new SqlDataAdapter("select EMPLOYEE.ID,EMPLOYEE.EMP_ID,EMPLOYEE.EMP_NAME,EMPLOYEE.EMP_GENDER,EMPLOYEE.EMP_PASS,Department.DepartmentName,EMPLOYEE.EMP_TEL,EMPLOYEE.EMP_EMAIL,EMPLOYEE.EMP_ADDRESS,EmployeeRoles.RoleName from Employee inner join Department on EMPLOYEE.DepartmentID = Department.ID inner join EmployeeRoles on EMPLOYEE.RoleID = EmployeeRoles.ID WHERE EMP_NAME LIKE '%" + searchValue + "%'", sqlConnection);
                    }

                    else if (searchByValue.ToLower() == "number")
                    {
                        sqlDataAdapter = new SqlDataAdapter("select EMPLOYEE.ID,EMPLOYEE.EMP_ID,EMPLOYEE.EMP_NAME,EMPLOYEE.EMP_GENDER,EMPLOYEE.EMP_PASS,Department.DepartmentName,EMPLOYEE.EMP_TEL,EMPLOYEE.EMP_EMAIL,EMPLOYEE.EMP_ADDRESS,EmployeeRoles.RoleName from Employee inner join Department on EMPLOYEE.DepartmentID = Department.ID inner join EmployeeRoles on EMPLOYEE.RoleID = EmployeeRoles.ID WHERE EMP_TEL LIKE '%" + searchValue + "%'", sqlConnection);
                    }

                    else if (searchByValue.ToLower() == "email")
                    {
                        sqlDataAdapter = new SqlDataAdapter("select EMPLOYEE.ID,EMPLOYEE.EMP_ID,EMPLOYEE.EMP_NAME,EMPLOYEE.EMP_GENDER,EMPLOYEE.EMP_PASS,Department.DepartmentName,EMPLOYEE.EMP_TEL,EMPLOYEE.EMP_EMAIL,EMPLOYEE.EMP_ADDRESS,EmployeeRoles.RoleName from Employee inner join Department on EMPLOYEE.DepartmentID = Department.ID inner join EmployeeRoles on EMPLOYEE.RoleID = EmployeeRoles.ID WHERE EMP_EMAIL LIKE '%" + searchValue + "%'", sqlConnection);
                    }

                    else if (searchByValue.ToLower() == "role")
                    {
                        sqlDataAdapter = new SqlDataAdapter("select EMPLOYEE.ID,EMPLOYEE.EMP_ID,EMPLOYEE.EMP_NAME,EMPLOYEE.EMP_GENDER,EMPLOYEE.EMP_PASS,Department.DepartmentName,EMPLOYEE.EMP_TEL,EMPLOYEE.EMP_EMAIL,EMPLOYEE.EMP_ADDRESS,EmployeeRoles.RoleName from Employee inner join Department on EMPLOYEE.DepartmentID = Department.ID inner join EmployeeRoles on EMPLOYEE.RoleID = EmployeeRoles.ID WHERE EMP_EMAIL LIKE '%" + searchValue + "%'", sqlConnection);
                    }

                    else
                    {
                        sqlDataAdapter = new SqlDataAdapter("select EMPLOYEE.ID,EMPLOYEE.EMP_ID,EMPLOYEE.EMP_NAME,EMPLOYEE.EMP_GENDER,EMPLOYEE.EMP_PASS,Department.DepartmentName,EMPLOYEE.EMP_TEL,EMPLOYEE.EMP_EMAIL,EMPLOYEE.EMP_ADDRESS,EmployeeRoles.RoleName from Employee inner join Department on EMPLOYEE.DepartmentID = Department.ID inner join EmployeeRoles on EMPLOYEE.RoleID = EmployeeRoles.ID WHERE EMP_ID LIKE '%" + searchValue + "%'", sqlConnection);
                    }
                }

                else if (tableValue == "ROOM")



                {
                    if (searchByValue.ToLower() == "Room No")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM WHERE ID LIKE '%" + searchValue + "%'", sqlConnection);
                    }

                    else if (searchByValue.ToLower() == "Type")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM WHERE ROOM_TYPE LIKE '%" + searchValue + "%'", sqlConnection);
                    }

                    else if (searchByValue.ToLower() == "Floor No")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM WHERE FLOOR_NO LIKE '%" + searchValue + "%'", sqlConnection);
                    }

                    else if (searchByValue.ToLower() == "Price")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM WHERE PRICE_PER_DAY LIKE '%" + searchValue + "%'", sqlConnection);
                    }
                }
                else if (tableValue == "INPATIENTS")
                {
                    if (searchByValue.ToLower() == "date of discharge")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT INPATIENT.ID, PATIENTS.ID As Patient_ID, PAT_NAME, PAT_TEL, DATE_OF_AD, DATE_OF_DIS, ROOM.ID AS ROOM_NUMBER, ROOM_TYPE, TotalAmount FROM INPATIENT INNER JOIN PATIENTS ON PATIENTS.ID = PAT_CODE INNER JOIN ROOM ON ROOM.ID = ROOM_CODE WHERE DATE_OF_DIS LIKE '%" + searchValue + "%'", sqlConnection);
                    }
                    else if (searchByValue.ToLower() == "patient tel")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT INPATIENT.ID, PATIENTS.ID As Patient_ID, PAT_NAME, PAT_TEL, DATE_OF_AD, DATE_OF_DIS, ROOM.ID AS ROOM_NUMBER, ROOM_TYPE, TotalAmount FROM INPATIENT INNER JOIN PATIENTS ON PATIENTS.ID = PAT_CODE INNER JOIN ROOM ON ROOM.ID = ROOM_CODE WHERE PAT_TEL LIKE '%" + searchValue + "%'", sqlConnection);
                    }
                    else if (searchByValue.ToLower() == "room no")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT INPATIENT.ID, PATIENTS.ID As Patient_ID, PAT_NAME, PAT_TEL, DATE_OF_AD, DATE_OF_DIS, ROOM.ID AS ROOM_NUMBER, ROOM_TYPE, TotalAmount FROM INPATIENT INNER JOIN PATIENTS ON PATIENTS.ID = PAT_CODE INNER JOIN ROOM ON ROOM.ID = ROOM_CODE WHERE ROOM_NO LIKE '%" + searchValue + "%'", sqlConnection);
                    }
                    else if (searchByValue.ToLower() == "room type")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT INPATIENT.ID, PATIENTS.ID As Patient_ID, PAT_NAME, PAT_TEL, DATE_OF_AD, DATE_OF_DIS, ROOM.ID AS ROOM_NUMBER, ROOM_TYPE, TotalAmount FROM INPATIENT INNER JOIN PATIENTS ON PATIENTS.ID = PAT_CODE INNER JOIN ROOM ON ROOM.ID = ROOM_CODE WHERE ROOM_TYPE LIKE '%" + searchValue + "%'", sqlConnection);
                    }
                    else if (searchByValue.ToLower() == "date of admission")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT INPATIENT.ID, PATIENTS.ID As Patient_ID, PAT_NAME, PAT_TEL, DATE_OF_AD, DATE_OF_DIS, ROOM.ID AS ROOM_NUMBER, ROOM_TYPE, TotalAmount FROM INPATIENT INNER JOIN PATIENTS ON PATIENTS.ID = PAT_CODE INNER JOIN ROOM ON ROOM.ID = ROOM_CODE WHERE DATE_OF_AD LIKE '%" + searchValue + "%'", sqlConnection);
                    }
                    else
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT INPATIENT.ID, PATIENTS.ID As Patient_ID, PAT_NAME, PAT_TEL, DATE_OF_AD, DATE_OF_DIS, ROOM.ID AS ROOM_NUMBER, ROOM_TYPE, TotalAmount FROM INPATIENT INNER JOIN PATIENTS ON PATIENTS.ID = PAT_CODE INNER JOIN ROOM ON ROOM.ID = ROOM_CODE WHERE PAT_NAME LIKE '%" + searchValue + "%'", sqlConnection);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable search(string searchValue, string searchByValue)
        {
            try
            {
                sqlConnection.Open();
                if (searchByValue.ToLower() == "room no")
                {
                    sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM WHERE ROOM_NO LIKE '%" + searchValue + "%'", sqlConnection);
                }
                else if (searchByValue.ToLower() == "type")
                {
                    sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM WHERE ROOM_STATUS = 'AVAILABLE' AND ROOM_TYPE LIKE '%" + searchValue + "%'", sqlConnection);
                }
                else if (searchByValue.ToLower() == "floor no")
                {
                    sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM WHERE ROOM_STATUS = 'AVAILABLE' AND FLOOR_NO LIKE '%" + searchValue + "%'", sqlConnection);
                }
                else
                {
                    sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM WHERE ROOM_STATUS = 'AVAILABLE'", sqlConnection);
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable search(string tableValue, string roomNo, string roomType, string floorNo)
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tableValue + " WHERE ROOM_STATUS = 'AVAILABLE' AND ROOM_NO LIKE '%" + roomNo + "%' AND ROOM_TYPE LIKE '%" + roomType + "%' AND FLOOR_NO LIKE '%" + floorNo + "%'", sqlConnection);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable searchPat(string searchValue, string searchByValue, string ID)
        {
            try
            {
                sqlConnection.Open();
                if (searchByValue.ToLower() == "patient name")
                {
                    sqlDataAdapter = new SqlDataAdapter("SELECT PAT_ID, PAT_NAME, PAT_GENDER, PAT_TEL, PAT_EMAIL, PAT_ADDRESS FROM PATIENTS INNER JOIN APPOINTMENT ON APPOINTMENT.PAT_CODE =PATIENTS.ID  where PAT_NAME LIKE '%" + searchValue + "%' AND DOC_CODE=" + ID + "", sqlConnection);
                }
                else if (searchByValue.ToLower() == "patient number")
                {
                    sqlDataAdapter = new SqlDataAdapter("SELECT PAT_ID, PAT_NAME, PAT_GENDER, PAT_TEL, PAT_EMAIL, PAT_ADDRESS FROM PATIENTS INNER JOIN APPOINTMENT ON APPOINTMENT.PAT_CODE =PATIENTS.ID  WHERE PAT_TEL LIKE '%" + searchValue + "%' AND DOC_CODE=" + ID + "", sqlConnection);
                }
                else
                {
                    sqlDataAdapter = new SqlDataAdapter("SELECT PAT_ID, PAT_NAME, PAT_GENDER, PAT_TEL, PAT_EMAIL, PAT_ADDRESS FROM PATIENTS INNER JOIN APPOINTMENT ON APPOINTMENT.PAT_CODE =PATIENTS.ID  WHERE PAT_ID LIKE '%" + searchValue + "%' AND DOC_CODE=" + ID + "", sqlConnection);
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public string getDoctorName(string doc_code)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT DOC_NAME FROM DOCTORS WHERE ID = '" + doc_code + "'", sqlConnection);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string value = Convert.ToString(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return value;
        }

        public DataTable doctorList()
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM DOCTORS ORDER BY DOC_NAME", sqlConnection);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable DepartmentList()
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Department ORDER BY DepartmentName", sqlConnection);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable RoleList()
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM DoctorRoles ORDER BY Rolename", sqlConnection);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }



        public DataTable patientList()
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM PATIENTS ORDER BY PAT_NAME", sqlConnection);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable roomList(string roomType)
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM WHERE ID not in (SELECT ROOM_CODE FROM INPATIENT INNER JOIN PATIENTS ON PATIENTS.ID = PAT_CODE INNER JOIN ROOM ON ROOM.ID = ROOM_CODE where DATE_OF_DIS >= '" + DateTime.Now.ToString("yyyy-MM-dd") + "' ) AND ROOM_TYPE = '" + roomType + "'", sqlConnection);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }


        public DataTable doctorsPatient(string docID)
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("SELECT PAT_ID, PAT_NAME, PAT_GENDER, PAT_TEL, PAT_EMAIL, PAT_ADDRESS FROM PATIENTS INNER JOIN APPOINTMENT ON APPOINTMENT.PAT_CODE =PATIENTS.ID  where  DOC_CODE = '" + docID + "'", sqlConnection);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public string getDoctorID(string email)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT ID FROM DOCTORS WHERE DOC_EMAIL = '" + email + "'", sqlConnection);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string value = Convert.ToString(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return value;
        }

        public void login(UserLogin userLogin, string actionType)
        {
            try
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("HMS_EMPLOYEE_LOGIN", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ActionType", actionType);
                    sqlCommand.Parameters.AddWithValue("@empEmail", userLogin.Username);
                    sqlCommand.Parameters.AddWithValue("@empPass", HashPassword(userLogin.Pass));

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.Read())
                        {
                            var dashBoard = serviceProvider.GetRequiredService<DashBoard>();
                            dashBoard.ID = sqlDataReader.GetValue(0).ToString().ToLower();
                            dashBoard.Role = sqlDataReader.GetValue(1).ToString().ToLower();
                            dashBoard.Departmental_ID = sqlDataReader.GetValue(2).ToString().ToLower();

                            dashBoard.Show();
                        }
                        else
                        {
                            MessageBox.Show("Unable to find Record of user with given email and password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (actionType == "doctorLogin")
                            {
                                var doctorLogin = new DoctorLogin(serviceProvider.GetRequiredService<IDatabaseOps>());
                                doctorLogin.Show();
                            }
                            else
                            {
                                var login = new Login(Program.ServiceProvider, _databaseOps);
                                login.Show();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        public DataTable getEmployeeDetail(string id)
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter(@"SELECT Doctors.ID,Doctors.DOC_ID,Doctors.DOC_NAME,Department.DepartmentName,Doctors.DOC_TEL,Doctors.DOC_EMAIL,Doctors.DOC_PASS,Doctors.DOC_GENDER,Doctors.DOC_ADDRESS,DoctorRoles.Rolename,DOCTORS.PricePerAppointment from Doctors 
                                                        inner join Department on Department.ID = Doctors.DOC_DEP_ID
                                                        inner join DoctorRoles on DoctorRoles.ID = Doctors.DOC_Role_ID WHERE Doctors.ID = " + int.Parse(id) + "", sqlConnection);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }


        public string[] getRoles()
        {
            string[] roles = new string[100];
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("HMS_GET_USER_ROLES", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ActionType", "");
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                int count = 0;
                while (sqlDataReader.Read())
                {
                    roles[count] = sqlDataReader.GetValue(0).ToString().ToLower();
                    count++;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return roles;
        }
    }
}
