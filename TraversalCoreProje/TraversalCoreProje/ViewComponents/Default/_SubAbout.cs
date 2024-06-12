using Business.Concrete;
using Data.Concrete.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
  
    public class _SubAbout:ViewComponent
    {  SubAboutManager SubAboutManager = new SubAboutManager(new EfCoreSubAboutDal());
        public IViewComponentResult Invoke() {
            var values = SubAboutManager.GetAll();
            
            
            return View(values); }
    }
}
