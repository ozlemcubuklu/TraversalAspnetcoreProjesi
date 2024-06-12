using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;
using TraversalCoreProje.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProje.CQRS.Queries;
using TraversalCoreProje.CQRS.Results;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _queryHandler;
        private readonly GetDestinationByIdHandler _getDestinationByIdHandler;
        private readonly CreateDestinationHandler _createDestinationHandler;
        private readonly DeleteDestinationHandler _deleteDestinationHandler;
        private readonly UpdateDestinationHandler _updateDestinationHandler;

        public DestinationCQRSController(UpdateDestinationHandler updateDestinationHandler ,DeleteDestinationHandler deleteDestinationHandler,GetAllDestinationQueryHandler queryHandler, GetDestinationByIdHandler getDestinationByIdHandler, CreateDestinationHandler createDestinationHandler)
        {
            _createDestinationHandler = createDestinationHandler;
            _queryHandler = queryHandler;
            _getDestinationByIdHandler = getDestinationByIdHandler;
            _deleteDestinationHandler = deleteDestinationHandler;
            _updateDestinationHandler = updateDestinationHandler;
        }

        public IActionResult Index()
        {
            var values = _queryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult GetDestinationById(int id)
        {
            var values = _getDestinationByIdHandler.Handle(new GetDestinationByIdQuery(id));

            return View(values);
        }
        [HttpPost]
        public IActionResult GetDestinationById(GetDestinationByIdQueryResult queryResult)
        {
            UpdateDestinationCommand command=new UpdateDestinationCommand() { Id=queryResult.Id,
                Price=queryResult.Price,
                DayNight=queryResult.DayNight,
                City=queryResult.City
            };
            _updateDestinationHandler.Handle(command);
             return RedirectToAction("Index", "DestinationCQRS", new { area = "Admin" });
        }
        [HttpGet]
        public ActionResult CreateDestination()
        {
            return View();
        }
            [HttpPost]
        public IActionResult CreateDestination(CreateDestinationCommand command)
        {
           _createDestinationHandler.Handle(command);
            return RedirectToAction("Index", "DestinationCQRS", new { area = "Admin" });


        }

        public IActionResult DeleteDestination(int id)
        {
            _deleteDestinationHandler.Handle(new DeleteDestinationCommand(id));
            return RedirectToAction("Index", "DestinationCQRS", new { area = "Admin" });

        }

    }
}
