using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.CQRS.Commands.DestinationCommads;
using TraversalCoreProje.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProje.CQRS.Queeries.DestinationQueries;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _queryHandler;
        private readonly GetDestinationByIdQueryHandler _getDestinationByIdQuery;
        private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
        private readonly RemoveDestinationCommandHandler _removeDestinationCommandHandler; 
        private readonly UpdateDestinationCommandHandler _updateDestinationCommandHandler;
        public DestinationCQRSController(GetAllDestinationQueryHandler queryHandler, GetDestinationByIdQueryHandler getDestinationByIdQuery, CreateDestinationCommandHandler createDestinationCommandHandler, RemoveDestinationCommandHandler removeDestinationCommandHandler, UpdateDestinationCommandHandler updateDestinationCommandHandler)
        {
            _queryHandler = queryHandler;
            _getDestinationByIdQuery = getDestinationByIdQuery;
            _createDestinationCommandHandler = createDestinationCommandHandler;
            _removeDestinationCommandHandler = removeDestinationCommandHandler;
            _updateDestinationCommandHandler = updateDestinationCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _queryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult GetDestination(int id)
        {
            var values = _getDestinationByIdQuery.Handle(new GetDestinationByIdQuery(id));
            return View(values);

        }
        [HttpPost]
        public IActionResult GetDestination(UpdateDestinationCommand command)
        {
            _updateDestinationCommandHandler.Handle(command); 
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost] 
        public IActionResult AddDestination(CreateDestinationCommand command)
        {
            _createDestinationCommandHandler.Handle(command); 
            return RedirectToAction("Index");   
        }  

        public IActionResult DeleteDestination(int id)  
        {  
             _removeDestinationCommandHandler.Handle(new RemoveDestinationCommand(id)); 
            return RedirectToAction("Index");
        }
       


    }
}
