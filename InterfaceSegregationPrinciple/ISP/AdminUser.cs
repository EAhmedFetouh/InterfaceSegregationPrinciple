
namespace InterfaceSegregationPrinciple.ISP
{
    public class AdminUser : IContentViewer, IUserManager
    {
        public void AddUser()
        {
            Console.WriteLine("Adding a new user as an admin.");
        }
        public void RemoveUser()
        {
            Console.WriteLine("Removing a user as an admin.");
        }
        public void ViewContent()
        {
            Console.WriteLine("Viewing content as an admin user.");
        }
    }
}
