using Microsoft.EntityFrameworkCore;
using System.Globalization;
using TP2.Data;
using TP2.Models;

namespace TP2.Services
{
    public class PlaneteService : IPlaneteService
    {
        #region Champs
        private List<Planète> _liste = new() { };
        private List<Caracteristique> _liste2 = new() { };
        private IPlaneteService.Type _type = IPlaneteService.Type.Liste;
        private PlaneteContext? _bd = null;
        #endregion

        #region Constructeurs
        public PlaneteService(IPlaneteService.Type type, PlaneteContext bd)
        {
            _type = type;
            _bd = bd;
        }
        #endregion

        #region Méthodes
        public Planète[] Lister()
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            if (_type == IPlaneteService.Type.Liste)
                return _liste.ToArray();
            else if (currentCulture.Name.StartsWith("fr"))
                return _bd!.Planètes.ToArray();
            else
                return _bd!.PlanètesEN.ToArray();
        }

        public Planète Trouver(int NoPlanète)
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            if (_type == IPlaneteService.Type.Liste)
                return _liste.First(t => t.NoPlanète == NoPlanète);

            else if (currentCulture.Name.StartsWith("fr"))
                return _bd!.Planètes
                    .Include(t => t.Image)
                    .First(t => t.NoPlanète == NoPlanète);
            else
                return _bd!.PlanètesEN.Include(t => t.Image).FirstOrDefault(t => t.NoPlanète == NoPlanète);
        }
        #endregion

        public Caracteristique[] Lister2()
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            if (_type == IPlaneteService.Type.Liste)
                return _liste2.ToArray();
            else if (currentCulture.Name.StartsWith("fr"))
                return _bd!.Caractéristiques.ToArray();
            else
                return _bd!.CaractéristiquesEN.ToArray();
        }
    }
}
