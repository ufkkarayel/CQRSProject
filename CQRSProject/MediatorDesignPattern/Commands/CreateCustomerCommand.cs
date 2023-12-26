using MediatR;

namespace CQRSProject.MediatorDesignPattern.Commands
{
    public class CreateCustomerCommand : IRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
    }
}
