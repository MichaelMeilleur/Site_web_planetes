using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;


namespace TP2.ViewComponents
{
    public class SelectLanguageViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cultureFeature = HttpContext.Features.Get<IRequestCultureFeature>();
            // Afin de conserver la langue choisie dans un Cookie
            HttpContext.Response.Cookies.Append(
            CookieRequestCultureProvider.DefaultCookieName,
            CookieRequestCultureProvider.MakeCookieValue(
            new RequestCulture(cultureFeature!.RequestCulture.UICulture)),
            new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );
            return View();
        }
    }
}
