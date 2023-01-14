// See https://aka.ms/new-console-template for more information
using DemoLibrary;

Person person = new Person();

person.SSN = "111-11-1111";
person.SayHello();

public class ModifiedDataAccess : DataAccess
{
    public void GetUnsecureConnectionInfo()
    {
        GetConnectionString();
    }
}

public class CEO : Manager
{
    public void GetConnectionInfo()
    {
        ModifiedDataAccess data = new ModifiedDataAccess();
        data.GetUnsecureConnectionInfo();
        
    }
}
