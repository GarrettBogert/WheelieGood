using System.Collections.Generic;
using WheelieGood.Core;

namespace WheelieGood.Data
{
    public interface IBikeData
    {
        IEnumerable<Bike> GetBikesByModel(string name);
        Bike GetById(int id);
        Bike Update(Bike bike);
        Bike Add(Bike newBike);
        Bike Delete(int id);
        int Commit();
        int GetCount();
    }
}
