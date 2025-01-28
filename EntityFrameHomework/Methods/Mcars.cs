using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameHomework.Class;

namespace EntityFrameHomework.Methods
{
    public class Mcars : Icars
    {
        public void Create(Car car)
        {
            AppDbContext newDb = new AppDbContext();
            newDb.Car.Add(car);
            newDb.SaveChanges();
        }

        public void Delete(int id)
        {
            AppDbContext newDb = new AppDbContext();
            var car = GetbyId(id);
            if (car != null) throw new Exception("Car is not found");
            newDb.Car.Remove(car);
            newDb.SaveChanges();
        }

        public Car GetbyId(int id)
        {
            AppDbContext newDb = new AppDbContext();
            return newDb.Car.FirstOrDefault(x => x.Id == id);
        }
        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Car car)
        {
            throw new NotImplementedException();
        }
    }
}
