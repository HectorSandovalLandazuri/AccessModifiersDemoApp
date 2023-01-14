// See https://aka.ms/new-console-template for more information
using DemoLibrary;

public class ModifiedDataAccess : DataAccess
{
    public void GetUnsecureConnectionInfo()
    {
        GetConnectionString();
    }
}
