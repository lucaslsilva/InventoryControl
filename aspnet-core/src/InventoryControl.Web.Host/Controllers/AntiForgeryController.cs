using Microsoft.AspNetCore.Antiforgery;
using InventoryControl.Controllers;

namespace InventoryControl.Web.Host.Controllers
{
    public class AntiForgeryController : InventoryControlControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
