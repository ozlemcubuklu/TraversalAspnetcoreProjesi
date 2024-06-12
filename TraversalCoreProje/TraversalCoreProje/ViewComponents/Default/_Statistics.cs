using Data.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;
using System.Linq;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Statistics : ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            using (var context=new Context())
            {
                ViewBag.rotasayisi = context.Destinations.Count();
                ViewBag.tursayisi = context.Guides.Count();
                ViewBag.müsterisayisi = "250";
            }
            return View();
        }
    }
}
