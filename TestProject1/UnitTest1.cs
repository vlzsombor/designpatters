namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    private string aaaa;

    public Tests()
    {
        aaaa = "helloworld";
    }
    List<string> list = new List<string>
    {
        "zsombor", "b", "c"
    };
    
    [Test]
    public void Test1()
    {

        var list = new List<string>
        {
            "a", "b", "c"
        };

        

        foreach (var variable in list)
        {
            Console.WriteLine(variable);
        }
    }
    
    
}