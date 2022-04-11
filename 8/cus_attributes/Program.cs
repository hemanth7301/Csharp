using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.All)]
public class SoftwareAttribute : System.Attribute
{
    public String ProjectName;
    public String Description;
    public String ClientName;
    public String StartedDate;
    public String EndDate;
    public SoftwareAttribute(string ProjectName, string Description, string ClientName, string StartedDate, string EndDate)
    {
        this.ProjectName = ProjectName;
        this.Description = Description;
        this.ClientName = ClientName;
        this.StartedDate = StartedDate;
        this.EndDate = EndDate;
    }

}
[SoftwareAttribute("fresher_bench", "new_series", "hemanth", "1-1-21", "12-12-22")]
class HDFCAccount
{
    public string name;
    public long acc_no;
    public HDFCAccount(string name, long acc_no)
    {
        this.name = name;
        this.acc_no = acc_no;

    }
}
[SoftwareAttribute("Other batch", "old one", "Mohan", "12-5-27", "2-2-32")]
class ICICIAccount
{
    public string name;
    public long acc_no;
    public ICICIAccount(string name, long acc_no)
    {
        this.name = name;
        this.acc_no = acc_no;

    }
}
namespace cus_attributes
{
    class Test
    {

        static void Main(string[] args)
        {

            System.Reflection.MemberInfo info = typeof(ICICIAccount);//HDFCAccount
            object[] attributes = info.GetCustomAttributes(true);

            for (int i = 0; i < attributes.Length; i++)
            {
                System.Console.WriteLine(attributes[i]);
            }


            foreach (Object attribute in attributes)
            {
                SoftwareAttribute dbi = (SoftwareAttribute)attribute;

                if (null != dbi)
                {
                    Console.WriteLine("ProjectName: {0}", dbi.ProjectName);
                    Console.WriteLine("Description: {0}", dbi.Description);
                    Console.WriteLine("ClientName: {0}", dbi.ClientName);
                    Console.WriteLine("StartedDate: {0}", dbi.StartedDate);
                    Console.WriteLine("EndDate: {0}", dbi.EndDate);

                }
            }

        }
    }
}
