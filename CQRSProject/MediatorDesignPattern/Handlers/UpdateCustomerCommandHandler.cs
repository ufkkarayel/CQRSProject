using CQRSProject.DAL.Context;
using CQRSProject.MediatorDesignPattern.Commands;
using MediatR;

namespace CQRSProject.MediatorDesignPattern.Handlers
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
    {
        private readonly SaleContext _context;

        public UpdateCustomerCommandHandler(SaleContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Customers.Find(request.CustomerID);
            values.Surname= request.Surname;
            values.Department= request.Department;
            values.Name= request.Name;
            await _context.SaveChangesAsync();
        }
    }
}
