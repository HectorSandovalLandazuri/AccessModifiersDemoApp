// See https://aka.ms/new-console-template for more information
using DemoLibrary;

public class CEO : Manager
{
    public void GetConnectionInfo()
    {
        ModifiedDataAccess data = new ModifiedDataAccess();
        data.GetUnsecureConnectionInfo();
        
    }
}
