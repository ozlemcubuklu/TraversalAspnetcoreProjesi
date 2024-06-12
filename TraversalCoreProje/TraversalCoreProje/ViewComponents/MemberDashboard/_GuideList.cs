using Business.Abstract;
using Business.Concrete;
using Data.Concrete.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _GuideList : ViewComponent
    {
        private readonly IGuideService _guideService;


        public _GuideList(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IViewComponentResult Invoke () {
            var values = _guideService.GetAll();
            return View(values);
        }
    }
}
