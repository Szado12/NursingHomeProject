using NursingHomeApp.Systems.DataManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.LogicalManagers
{
    class PlaceManager
    {
        PlaceDataManager placeDataManager = new PlaceDataManager();
        public bool Add(string name)
        {
            Place place = new Place()
            {
                Name = name
            };
            return placeDataManager.Add(place);
        }
        public bool Delete(int Id)
        {
            return placeDataManager.Delete(Id);
        }
        public bool Update(int Id,string name)
        {
            Place place = new Place()
            {
                Id = Id,
                Name = name
            };
            return placeDataManager.Update(place);
        }
        public List<Place> Select()
        {
            return placeDataManager.Select();
        }
        public Place Select(int Id)
        {
            return placeDataManager.Select(Id);
        }
    }
}
