using CQRSProject.MediatorDesignPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task< IActionResult> Index()
        {
            var values =await _mediator.Send(new GetAllCustomerQuery());
            return View(values);
        }
    }
}
