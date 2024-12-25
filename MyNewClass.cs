// ReSharper disable ExtractCommonBranchingCode

namespace part3Unit1of9;
public class MyNewClass
{
    public void DoSomething(string massage, string? myName)
    {
        // Create an instance of MySecondNewClass
        MySecondNewClass mySecondNewClass = new MySecondNewClass();

        string[] passwords = new[] { "123456", "999444", "888333", "777fg123" };
        if (!passwords.Contains(massage))
        {
            Console.WriteLine($"\n{myName} You've entered - {massage}.\nThe password is incorrect!");
        }
        else
        {
            // Call the method from MySecondNewClass
            mySecondNewClass.MySecondMethod(massage, myName);
        }
    }
}
