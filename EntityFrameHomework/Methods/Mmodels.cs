using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameHomework.Class;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameHomework.Methods
{
    public class Mmodels : Imodels
    {
        public void Create(Model model)
        {
            AppDbContext newDb = new AppDbContext();
            newDb.Model.Add(model);
            newDb.SaveChanges();
        }

        public void Delete(int id)
        {
            AppDbContext newDb = new AppDbContext();
            var model = GetbyId(id);
            if (model != null) throw new Exception("Model is not found");
            newDb.Model.Remove(model);
            newDb.SaveChanges();
        }

        public Model GetbyId(int id)
        {
            AppDbContext newDb = new AppDbContext();
            return newDb.Model.FirstOrDefault(x => x.Id == id);
        }
        public List<Model> GetAll()
        {
            AppDbContext newdb = new AppDbContext();
            return newdb.Model.ToList();
        }

        public void Update(int id, Model model)
        {
            AppDbContext newDb = new AppDbContext();
            var existmodel = GetbyId(id);
            if (model != null) throw new Exception("Genre is not found");
            existmodel.Name = model.Name;
            newDb.SaveChanges();
        }
    }
}
