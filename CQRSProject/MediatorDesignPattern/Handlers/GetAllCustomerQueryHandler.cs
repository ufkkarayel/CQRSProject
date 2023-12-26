using CQRSProject.MediatorDesignPattern.Queries;
using CQRSProject.MediatorDesignPattern.Results;
using MediatR;

namespace CQRSProject.MediatorDesignPattern.Handlers
{
    public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQuery, List<GetAllCustormerQueryResult>>
    {
        public Task<List<GetAllCustormerQueryResult>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
