using DataAccess.Data;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.DataBase.Wood
{
    public static class WoodCRUD
    {
        public static List<WoodType> GetWoodList()
        {
            using (var Context = new AppDbContext())
            {
                return Context.WoodTypes.ToList();
            }
        }

        public static WoodType GetWoodByName(string WoodName)
        {
            using (var Context = new AppDbContext()) 
            {
                return Context.WoodTypes.SingleOrDefault(w => w.Type == WoodName)!;
            }
        }
    }
}
