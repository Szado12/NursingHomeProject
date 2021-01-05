using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Views
{
    public class PatientMedicineView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Dose { get; set; }
        public System.TimeSpan Time { get; set; }
    }
}
