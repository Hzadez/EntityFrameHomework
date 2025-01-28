using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameHomework.Class;

namespace EntityFrameHomework.Methods
{
    public interface Imodels
    {
        void Create(Model model);
        void Delete(int id);
        void Update(int id, Model model);
        Model GetbyId(int id);
        List<Model> GetAll();
    }
}
