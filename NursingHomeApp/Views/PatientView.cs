using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Views
{
    public class PatientView
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonId { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactNumber { get; set; }
        public string Alergies { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public virtual List<ScheduleView> Schedule { get; set; }
        public Nullable<int> RoomID { get; set; } 
    }
}
