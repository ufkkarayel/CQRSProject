using CQRSProject.CQRSPattern.Commands;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRSPattern.Handlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly SaleContext _context;

        public RemoveCategoryCommandHandler(SaleContext context)
        {
            _context = context;
        }
        public void Handle(RemoveCategoryCommand command)
        {
            var value = _context.Categories.Find(command.ID);
            _context.Categories.Remove(value);
            _context.SaveChanges();
        }
    }
}
