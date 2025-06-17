
namespace InterfaceSegregationPrinciple.ISP;

internal class RegularUser : IContentViewer
{
    public void ViewContent()
    {
        Console.WriteLine("Viewing content as a regular user.");
    }
}
