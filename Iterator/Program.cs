using System.Collections;

namespace Iterator;

class Program
{
    static void Main(string[] args)
    {

        var menu = new Menu();

        foreach (var menuItem in menu)
        {
            Console.WriteLine(menuItem);
        }

        
        var enumeration = menu.GetEnumerator();
        while (enumeration.MoveNext())
        {
            Console.WriteLine(enumeration.Current);
        }
        
        Console.WriteLine("Hello, World!");
    }
}

class Menu : IEnumerable
{

    private List<string> menu = new List<string>
    {
        "a",
        "b",
        "c"
    };

    class OwnEnumerator : IEnumerator<string>
    {

        private string[] strs = new[] { "str", "str1", "str2" };
        private int currentIndex = 0;

        public bool MoveNext()
        {
            if (currentIndex >= strs.Length)
            {
                return false;
            }

            Current = strs[currentIndex++];
            return true;
        }

        public void Reset()
        {
            currentIndex = 0;
        }

        public string Current { get; private set;  }

        object? IEnumerator.Current => Current;

        public void Dispose()
        {
            Reset();
        }
    }

    private OwnEnumerator _enumerator = new OwnEnumerator(); 
    
    public IEnumerator GetEnumerator()
    {
        return _enumerator;
    }


}

