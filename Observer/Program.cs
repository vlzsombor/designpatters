namespace Observer;

class Program
{
    static void Main(string[] args)
    {
        WeatherProcessor weatherProcessor = new WeatherProcessor();

        
        IObserver<WeatherData> phone = new Phone(weatherProcessor);
        SpecialDevice specialDevice = new SpecialDevice(weatherProcessor);
        
        weatherProcessor.UpdateDate(new WeatherData(32, 22, "noon"));
        
        specialDevice.Unsubscribe();
        weatherProcessor.UpdateDate(new WeatherData(32, 22, "noon"));
        
    }
}

record WeatherData(int temp, int humidity, string name);

class Phone : IObserver<WeatherData>
{
    private readonly IDisposable unsubscribe;

    public Phone(IObservable<WeatherData> observable)
    {
        unsubscribe = observable.Subscribe(this);
    }
    
    public void OnCompleted()
    {
        Console.WriteLine("completed :) Phone");
        unsubscribe.Dispose();
    }

    public void OnError(Exception error)
    {
        Console.WriteLine("ERROR :c Phone");
    }

    public void OnNext(WeatherData value)
    {
        Console.WriteLine("on next :O Phone");
    }
}

class SpecialDevice : IObserver<WeatherData>
{
    private readonly IDisposable unsubscribe;

    public SpecialDevice(IObservable<WeatherData> observable)
    {
        unsubscribe = observable.Subscribe(this);
    }
    public void OnCompleted()
    {
        Console.WriteLine("completed :) SpecialDevice");
        unsubscribe.Dispose();
    }
    public void Unsubscribe()
    {
        unsubscribe.Dispose();
    }
    public void OnError(Exception error)
    {
        Console.WriteLine("ERROR :c SpecialDevice");
    }

    public void OnNext(WeatherData value)
    {
        Console.WriteLine("on next :O SpecialDevice!!");
    }
}

class WeatherProcessor : IObservable<WeatherData>
{
    public List<IObserver<WeatherData>> Observers { get; set; } = new List<IObserver<WeatherData>>();

    public List<WeatherData> WeatherDatas { get; set; } = new List<WeatherData>();

    public void UpdateDate(WeatherData weatherData)
    {
        WeatherDatas.Add(weatherData);
        Observers.ForEach(o => o.OnNext(weatherData));
    }

    public IDisposable Subscribe(IObserver<WeatherData> observer)
    {
        Observers.Add(observer);
        return new Unsubscriber(Observers, observer);
    }

    private class Unsubscriber : IDisposable
    {
        private readonly List<IObserver<WeatherData>> _observers;
        private readonly IObserver<WeatherData> _observer;

        public Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {

            Console.WriteLine($"unsubscribed {_observer}");
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}