using CQRSProject.MediatorDesignPattern.Results;
using MediatR;

namespace CQRSProject.MediatorDesignPattern.Queries
{
    public class GetAllCustomerQuery : IRequest<List<GetAllCustormerQueryResult>>
    {
    }
}
