using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameHomework.Class;

namespace EntityFrameHomework.Methods
{
    public interface Icolors
    {
        void Create(Color color);
        void Delete(int id);
        void Update(int id, Color color);
        Color GetbyId(int id);
        List<Color> GetAll();
    }
}
