using WheelieGood.Data;
using WheelieGood.Core;
using System.Collections.Generic;
using System.Linq;

namespace WheelieGood.Data
{
    public class SqlBikeData : IBikeData
    {
        private readonly WheelieGoodDbContext db;
        public SqlBikeData(WheelieGoodDbContext db)
        {
            this.db = db;
        }
        public Bike Add(Bike newBike)
        {
            db.Add(newBike);
            return newBike;
        }

        public int Commit()
        {
            return db.SaveChanges(); 
        }

        public Bike Delete(int id)
        {
            var bike = GetById(id);
            if (bike != null)
            {
                db.Bikes.Remove(bike);
            }
            return bike;
        }

        public IEnumerable<Bike> GetBikesByModel(string model)
        {
            if (!string.IsNullOrEmpty(model))
            {
                return db.Bikes.Where(b => b.Model == model).OrderBy(bi => bi.Model);
            }
            else
            {
                return db.Bikes;
            }
        }

        public Bike GetById(int id)
        {
            return db.Bikes.Find(id);
        }

        public int GetCount()
        {
            return db.Bikes.Count();
        }

        public Bike Update(Bike bike)
        {
            var entity = db.Bikes.Attach(bike);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return bike;
        }
    }
}
