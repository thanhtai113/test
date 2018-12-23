using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Model.Food_Entity;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;

namespace Model
{
    public class ModelContext: DbContext
    {
        public ModelContext(): base("conn")
        {
            Database.SetInitializer<ModelContext>(null);
        }
        public DbSet<Food_Type> type_list { get; set; }
        public DbSet<Food_Size> size_list { get; set; }
        public DbSet<Food_Dish> dish_list { get; set; }
        public DbSet<Accounts> account_list { get; set; }
        public DbSet<Positions> position_list { get; set; }
        public DbSet<CusOrders> cusOrder_list { get; set; }
        public DbSet<OrderHistorys> orderHistory_list { get; set; }
    }
    
}
