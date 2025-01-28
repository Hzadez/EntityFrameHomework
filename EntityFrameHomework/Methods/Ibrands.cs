
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameHomework.Class;

namespace EntityFrameHomework.Methods
{
    public interface Ibrands
    {
        void Create(Brand brand);
        void Delete(int id);
        void Update(int id,Brand brand);
        Brand GetbyId(int id);
        List<Brand> GetAll();
        
    }
}
