using TP2.Models;
using TP2.Services;
using Microsoft.AspNetCore.Mvc;

namespace TP2.ViewComponents
{
    public class PubViewComponent : ViewComponent
    {

        #region Propriétés
        public PubViewModel ViewModel { get; set; } = new();
        #endregion

        #region Méthodes
        public IViewComponentResult Invoke(string date, string message)
        {
            ViewModel.Date = date;
            ViewModel.Message = message;

            return View(this);
        }
        #endregion
    }
}
