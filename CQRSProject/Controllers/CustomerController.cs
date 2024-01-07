﻿using CQRSProject.MediatorDesignPattern.Commands;
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
        [HttpGet]
        public IActionResult CreateCustomer() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CreateCustomerCommand command)
        {
            await _mediator.Send(command);
            return View();
        }
        public  async Task<IActionResult> DeleteCustomer(int id)
        {
            await _mediator.Send(new RemoveCustomerCommand(id));
            return RedirectToAction("Index");
        }
    }
}
