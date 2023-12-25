namespace CQRSProject.DAL.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Category> Categories { get; set; }
    }
}
