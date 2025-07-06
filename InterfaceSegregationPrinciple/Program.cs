
/*
  Interface Segregation Principle :-
   "Clients should not be forced to depend on interfaces they do not use."
   */

using InterfaceSegregationPrinciple.ISP;

var regularUser = new RegularUser();
regularUser.ViewContent();

var adminUser = new AdminUser();
adminUser.ViewContent();
adminUser.AddUser();
adminUser.RemoveUser();


//public interface IUser
//{
//    void ViewContent();
//    void AddUser();
//    void RemoveUser();
//}

//public class RegularUser: IUser
//{
//    public void ViewContent()
//    {
//        Console.WriteLine("Viewing content as a regular user.");
//    }
//    public void AddUser()
//    {
//        throw new NotImplementedException("Regular users cannot add users.");
//    }
//    public void RemoveUser()
//    {
//        throw new NotImplementedException("Regular users cannot remove users.");
//    }
//}

//public class AdminUser : IUser
//{
//    public void ViewContent()
//    {
//        Console.WriteLine("Viewing content as an admin user.");
//    }
//    public void AddUser()
//    {
//        Console.WriteLine("Adding a new user as an admin.");
//    }
//    public void RemoveUser()
//    {
//        Console.WriteLine("Removing a user as an admin.");
//    }
//}