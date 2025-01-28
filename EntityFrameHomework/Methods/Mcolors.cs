using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameHomework.Class;

namespace EntityFrameHomework.Methods
{
    public class Mcolors : Icolors
    {
        public void Create(Color color)
        {
            AppDbContext newDb = new AppDbContext();
            newDb.Color.Add(color);
            newDb.SaveChanges();
        }

        public void Delete(int id)
        {
            AppDbContext newDb = new AppDbContext();
            var color = GetbyId(id);
            if (color != null) throw new Exception("Color is not found");
            newDb.Color.Remove(color);
            newDb.SaveChanges();
        }

        public Color GetbyId(int id)
        {
            AppDbContext newDb = new AppDbContext();
            return newDb.Color.FirstOrDefault(x => x.Id == id);
        }
        public List<Color> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Color color)
        {
            throw new NotImplementedException();
        }
    }
}
