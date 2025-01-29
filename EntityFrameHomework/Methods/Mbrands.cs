using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameHomework.Class;

namespace EntityFrameHomework.Methods
{
    public class Mbrands : Ibrands
    {
        public void Create(Brand brand)
        {
            AppDbContext newDb = new AppDbContext();
            newDb.Brand.Add(brand);
            newDb.SaveChanges();
        }

        public void Delete(int id)
        {
            AppDbContext newDb = new AppDbContext();
            var brand = GetbyId(id);
            if (brand != null) throw new Exception("Brand is not found");
            newDb.Brand.Remove(brand);
            newDb.SaveChanges();
        }

        public Brand GetbyId(int id)
        {
            AppDbContext newDb = new AppDbContext();
            return newDb.Brand.FirstOrDefault(x => x.Id == id);
        }
        public List<Brand> GetAll()
        {
            AppDbContext newdb = new AppDbContext();
            return newdb.Brand.ToList();
        }

        public void Update(int id, Brand brand)
        {
            AppDbContext newDb = new AppDbContext();
            var existbrand = GetbyId(id);
            if (brand != null) throw new Exception("Genre is not found");
            existbrand.Name = brand.Name;
            newDb.SaveChanges();
        }       
    }
}
