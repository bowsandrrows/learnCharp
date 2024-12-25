namespace part3Unit1of9;
public class MySecondNewClass
{
    public void MySecondMethod(string massage, string? myName)
    {
        if (massage == massage.Trim().ToLower())
            Console.WriteLine($"\nHello, {myName} you've entered - {massage}\nThis password is correct");
    }
}
