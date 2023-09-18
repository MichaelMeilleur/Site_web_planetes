using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP2.Services;
using TP2.Models;

namespace TP2.Pages.Planetes
{
    /// <summary>
    /// Auteurs : Michael Meilleur et Mahdi Ellili
    /// Date : 2022-11-15
    /// Description : Classe pour la page Details
    /// </summary>

    public class DetailsModel : PageModel
    {
        #region Champs
        private IPlaneteService? _service = null;
        #endregion

        #region Propriétés
        public Planète Planète { get; set; }
        public Caracteristique[]? Caracteristique { get; set; }
        #endregion

        #region Constructeurs
        public DetailsModel(IPlaneteService service)
        {
            _service = service;
        }
        #endregion


        #region Méthodes
        public void OnGet(int noplanète)
        {
            Planète = _service!.Trouver(noplanète);
            Caracteristique = _service!.Lister2();
        }
        #endregion
    }
}
