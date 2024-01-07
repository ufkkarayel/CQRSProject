using CQRSProject.CQRSPattern.Commands;
using CQRSProject.DAL.Context;
using CQRSProject.MediatorDesignPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace CQRSProject.MediatorDesignPattern.Handlers
{
    public class RemoveCustomerCommandHandler : IRequestHandler<RemoveCustomerCommand>
    {
        private readonly SaleContext _context;

        public RemoveCustomerCommandHandler(SaleContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveCustomerCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Customers.Find(request.Id);
            _context.Customers.Remove(values);
            await _context.SaveChangesAsync(); 
        }
    }
}
