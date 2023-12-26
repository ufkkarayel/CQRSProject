namespace CQRSProject.CQRSPattern.Commands
{
    public class RemoveCategoryCommand
    {
        public int ID { get; set; }
        public RemoveCategoryCommand(int id)
        {
            ID = id;
        }   
    }
}
