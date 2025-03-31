namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        int[] array = { 1, 2, 3 };

        Assert.True(array.Length == 2);
    }
    
    
}