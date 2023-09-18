using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using TP2.Models;
using TP2.Pages;


namespace TP2.Pages.Planetes
{
    public class SondageModel : PageModel
    {
        #region Enumérations
        public enum ActionsPossible {Envoyer,Recommencer}
        #endregion

        #region Propriétés
        [BindProperty]
        public SondageViewModel SondageViewModel { get; set; } = new SondageViewModel();
 
        #endregion

        public void OnGet()
        {
        }
        public IActionResult OnPost(int action)
        {
            if ((ActionsPossible)action == ActionsPossible.Envoyer)
            {
                if (ModelState.IsValid)
                {
                    SondageViewModel.Validation = true;
                    return Page();  
                }
                else
                {
                    foreach (var modelstate in ModelState.Values)
                    {
                        foreach (var error in modelstate.Errors)
                        {
                            SondageViewModel.Validation = false;
                            ModelState.AddModelError("", error.ErrorMessage);
                        }
                    }
                    return Page();
                }
            }

            else
                return RedirectToPage();
        }
    }
}