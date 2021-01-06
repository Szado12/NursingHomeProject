using NursingHomeApp.Systems.DataManagers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.DataManagers
{
    public class PlaceDataManager : DefaultDataManager, IPlaceDataManger
    {
        public bool Add(Place t)
        {
            DbContext.Places.Add(t);
            return (DbContext.SaveChanges() > 0);
        }

        public bool Delete(int Id)
        {
            Place place = DbContext.Places.SingleOrDefault(p => p.Id == Id);
            DbContext.Places.Remove(place);
            return (DbContext.SaveChanges() > 0);
        }

        public List<Place> Select()
        {
            return DbContext.Places.ToList();
        }

        public Place Select(int Id)
        {
            return DbContext.Places.SingleOrDefault(p => p.Id == Id);
        }

        public bool Update(Place t)
        {
            Place place = DbContext.Places.SingleOrDefault(p => p.Id == t.Id);
            place.Name = place.Name;
            return (DbContext.SaveChanges() > 0);
        }
    }
}
