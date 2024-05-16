using Microsoft.AspNetCore.Mvc;
using Pronia.DataAccesLayer;

namespace Pronia.ViewComponents
{
    public class HeaderViewComponent(ProniaContext _context) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
