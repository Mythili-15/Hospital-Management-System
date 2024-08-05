using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Models;

namespace HopitalManagementSystem
{
    public interface IDatabaseOps
    {
        DataTable timeslotlist(int docid);
        DataTable GetAppointmentofDoctor(int docid);
        DataTable GetAppointmentofDoctor(int docid, string by);
        DataTable doctorsPatient(string docID);
        int gettimeslotidfromappointment(string apid);
        void updatetimeslotavailability(int id, int yesorno);
        void update(Doctor doctor, string DoctorLogin);
        void update(Doctor doctor);
        void update(Appointment appointment);
        void insert(Appointment appointment);
        void insert(Doctor doctor);
        void insertavailability(Doctor doctor);
        int GetIDbyName(string tablename, string name, string colname, string colname2);
        void insert(Employee employee);
        void insert(Patient patient);
        void insert(Room room);
        void insert(Inpatient inpatient);
        void update(Patient patient);
        void update(Inpatient inpatient);
        void makeslotsavailable();
        void update(Employee employee);
        void updateRoomAvailability(int id, string status);
        void update(Room room);
        void DeleteTimeSlots(int id);
        void delete(string tableValue, string id);
        string HashPassword(string password);
        DataTable display(string value);
        DataTable displayInPat();
        DataTable displayAppointment(string Id);
        DataTable doctorAppointment();
        DataTable display();
        void Showincbx(ComboBox cbx, string tablename, string colname);

        DataTable search(string tableValue, string searchValue, string searchByValue);
        DataTable search(string searchValue, string searchByValue);
        DataTable search(string tableValue, string roomNo, string roomType, string floorNo);
        DataTable searchPat(string searchValue, string searchByValue, string ID);
        string getDoctorName(string doc_code);
        DataTable doctorList();
        DataTable DepartmentList();
        DataTable RoleList();
        DataTable patientList();
        DataTable roomList(string roomType);
        string getDoctorID(string email);
        void login(UserLogin userLogin, string actionType);
        DataTable getEmployeeDetail(string id);
        string[] getRoles();
    }
}
