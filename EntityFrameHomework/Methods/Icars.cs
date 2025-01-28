using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameHomework.Class;

namespace EntityFrameHomework.Methods
{
    public interface Icars
    {
        void Create(Car car);
        void Delete(int id);
        void Update(int id, Car car);
        Car GetbyId(int id);
        List<Car> GetAll();
    }
}
