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

        #region Propri�t�s
        public Plan�te Plan�te { get; set; }
        public Caracteristique[]? Caracteristique { get; set; }
        #endregion

        #region Constructeurs
        public DetailsModel(IPlaneteService service)
        {
            _service = service;
        }
        #endregion


        #region M�thodes
        public void OnGet(int noplan�te)
        {
            Plan�te = _service!.Trouver(noplan�te);
            Caracteristique = _service!.Lister2();
        }
        #endregion
    }
}
