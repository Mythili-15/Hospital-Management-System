using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopitalManagementSystem
{
    public class Patient : Person
    {
        public int CreatedBy { get; set; }
        public DateTime Date { get; set; }
        public Patient() : base() { }
        public Patient(string iD, string name, string email, string gender, string tel, string address, int createdby, DateTime date) : base(iD, name, email, gender, tel, address)
        {
            this.CreatedBy = createdby;
            this.Date = date;
        }
    }
}
