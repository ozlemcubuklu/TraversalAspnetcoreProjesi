using Business.Abstract;
using Business.Concrete;
using Data.Concrete.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _PopulerDestination:ViewComponent
    {
     private readonly IDestinationService _destinationService;

        public _PopulerDestination(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationService.GetAll();
            return View(values);
        }
    }
}
