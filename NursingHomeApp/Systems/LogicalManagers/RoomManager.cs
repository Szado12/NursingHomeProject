using NursingHomeApp.Systems.DataManagers;
using NursingHomeApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.LogicalManagers
{
    public class RoomManager
    {
        RoomDataManager roomDataManager = new RoomDataManager();

        public bool Add(int capacity)
        {
            Room room = new Room()
            {
                Capacity = capacity
            };

            return roomDataManager.Add(room);
        }

        public bool Delete(int Id)
        {
            return roomDataManager.Delete(Id);
        }

        public List<RoomView> Select()
        {
            return roomDataManager.Select();
        }

        public RoomView Select(int Id)
        {
            return roomDataManager.Select(Id);
        }

        public bool Update(int capacity)
        {
            Room room = new Room()
            {
                Capacity = capacity
            };

            return roomDataManager.Update(room);
        }
    }
}
