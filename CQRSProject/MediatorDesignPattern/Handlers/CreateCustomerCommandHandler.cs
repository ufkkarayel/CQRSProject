﻿using CQRSProject.DAL.Context;
using CQRSProject.DAL.Entities;
using CQRSProject.MediatorDesignPattern.Commands;
using MediatR;

namespace CQRSProject.MediatorDesignPattern.Handlers
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand>
    {
        private readonly SaleContext _context;

        public CreateCustomerCommandHandler(SaleContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            _context.Customers.Add(new Customer
            {
                Department = request.Department,
                Name = request.Name,
                Surname = request.Surname,
            });
            await _context.SaveChangesAsync();
        }
    }
}
