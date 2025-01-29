using EntityFrameHomework.Class;
using EntityFrameHomework.Methods;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace EntityFrameHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ibrands Mbrands = new Mbrands();
            Mbrands.Create(new Brand() {Name = "Audi"});
            Imodels Mmodels = new Mmodels();
            Mmodels.Create(new Model(){Name = "A8"});
            Icars Mcars = new Mcars();
            Mcars.Create(new Car() { Maxspeed = 320,Fueltank = 300,Power = 4.2,Doorcount = 4});
            Icolors Mcolors = new Mcolors();
            Mcolors.Create(new Color() {Name = "Black"});
            
        }
 
    }
}
