using CQRSProject.DAL.Context;
using CQRSProject.MediatorDesignPattern.Queries;
using CQRSProject.MediatorDesignPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSProject.MediatorDesignPattern.Handlers
{
    public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQuery, List<GetAllCustormerQueryResult>>
    {
        private readonly SaleContext _context;

        public GetAllCustomerQueryHandler(SaleContext context)
        {
            _context = context;
        }

        public async Task<List<GetAllCustormerQueryResult>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
        {
            return await _context.Customers.Select(x=>new GetAllCustormerQueryResult
            {
                CustomerID = x.CustomerID,
                Department=x.Department,
                Name = x.Name,
                Surname = x.Surname,
            }).ToListAsync();
        }
    }
}
