using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP2.Models;
using TP2.Services;

namespace TP2.Pages
{
    /// <summary>
    /// Auteurs : Michael Meilleur et Mahdi Ellili
    /// Date : 2022-11-15
    /// Description : Classe pour la page Index
    /// </summary>
    public class IndexModel : PageModel
    {
        #region Champs
        private IPlaneteService? _service = null;
        #endregion

        #region Propriétés
        public Planète[]? Planètes { get; set; }
        #endregion

        #region Constructeurs
        public IndexModel(IPlaneteService service)
        {
            _service = service;
        }
        #endregion

        public void OnGet(int noplanete)
        {
            Planètes = _service!.Lister();

            for (int i = 0; i < Planètes.Length; i++)
            {
                Planètes[i] = _service!.Trouver(i + 1);
            }
        }
    }
}