using TP2.Models;
using Microsoft.EntityFrameworkCore;

namespace TP2.Data
{
    public class PlaneteContext : DbContext
    {
        #region Constructeurs
        public PlaneteContext(DbContextOptions options) : base(options) 
        {

        }
        #endregion

        public DbSet<PlanèteFR> Planètes { get; set; }
        public DbSet<PlanèteEN> PlanètesEN { get; set; }    
        public DbSet<Image> images { get; set; }
        public DbSet<CaracteristiqueFR> Caractéristiques { get; set; }
        public DbSet<CaracteristiqueEN> CaractéristiquesEN { get; set; }   
    }
}
