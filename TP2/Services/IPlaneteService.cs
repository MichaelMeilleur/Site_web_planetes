using TP2.Models;

namespace TP2.Services
{
    public interface IPlaneteService
    {
        public enum Type 
        {
            BaseDonnées,
            Liste
        }
        public Planète[] Lister();
        public Planète Trouver(int NoPlanète);
        public Caracteristique[] Lister2();
    }
}
