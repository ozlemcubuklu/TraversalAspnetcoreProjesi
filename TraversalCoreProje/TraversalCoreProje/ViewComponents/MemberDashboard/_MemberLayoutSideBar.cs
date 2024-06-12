using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _MemberLayoutSideBar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
