using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Views
{
    public class ScheduleView
    {
        public int Id { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }

        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string TreatmentName { get; set; }
        public string PlaceName { get; set; }
        public System.DateTime Term { get; set; }

    }
}
