using Data.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProje.ViewComponents.AdminDashboard
{
    public class _Card1Statistic:ViewComponent
    {
        Context c=new Context();
        public IViewComponentResult Invoke() {
            ViewBag.tursayisi = c.Destinations.Count();
            ViewBag.misafirsayisi=c.Users.Count();
            
            
            return View(); }
    }
}
