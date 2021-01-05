using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Views
{
    public class RoomView
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public virtual List<PatientOnListView> Patients { get; set; }
    }
}
