using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NursingHomeApp.Systems.DataManagers.Interfaces;
using NursingHomeApp.Systems.DataMangers.Interfaces;
using NursingHomeApp.Views;

namespace NursingHomeApp.Systems.DataManagers
{
    class RoomDataManager : DefaultDataManager, IRoomDataManger
    {
        public bool Add(Room t)
        {
            DbContext.Rooms.Add(t);
            return (DbContext.SaveChanges() > 0);
        }

        public bool Delete(int Id)
        {
            Room room = DbContext.Rooms.SingleOrDefault(p => p.Id == Id);
            DbContext.Rooms.Remove(room);
            return (DbContext.SaveChanges() > 0);
        }

        public List<RoomView> Select()
        {
            List<Room> rooms = DbContext.Rooms.ToList();
            return Mapper.Map<List<Room>, List<RoomView>>(rooms);
        }

        public RoomView Select(int Id)
        {
            Room room = DbContext.Rooms.SingleOrDefault(p => p.Id == Id);
            RoomView roomView = Mapper.Map<Room, RoomView>(room);
            return roomView;
        }

        public bool Update(Room t)
        {
            Room room = DbContext.Rooms.SingleOrDefault(p => p.Id == t.Id);
            room = t;
            return (DbContext.SaveChanges() > 0);
        }
    }
}
