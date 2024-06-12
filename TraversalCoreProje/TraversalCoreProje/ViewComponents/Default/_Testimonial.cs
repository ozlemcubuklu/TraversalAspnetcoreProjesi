using Business.Concrete;
using Data.Concrete.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfCoreTestimonialDal());
        public IViewComponentResult Invoke() {
            var values = testimonialManager.GetAll();
                return View(values); }
    }
}
