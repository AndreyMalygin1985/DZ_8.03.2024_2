// Создать базовый класс «Устройство» и производные классы «Чайник», «Микроволновка», «Автомобиль»,
// «Пароход». С помощью конструктора установить имя каждого устройства и его характеристики.
//Реализуйте для каждого из классов методы:
//		■	Sound — издает звук устройства (пишем текстом в консоль);
//		■	Show — отображает название устройства;
//		■	Desc — отображает описание устройства.


class Device
{
    protected string name;

    public Device(string name)
    {
        this.name = name;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Звук устройства");
    }

    public void Show()
    {
        Console.WriteLine("Название устройства: " + name);
    }

    public virtual void Desc()
    {
        Console.WriteLine("Описание устройства");
    }
}

class Kettle : Device
{
    public Kettle(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Шум кипящей воды");
    }

    public override void Desc()
    {
        Console.WriteLine("Чайник - устройство для кипячения воды");
    }
}

class Microwave : Device
{
    public Microwave(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Жужжание микроволновки");
    }

    public override void Desc()
    {
        Console.WriteLine("Микроволновка - устройство для разогрева пищи");
    }
}

class Car : Device
{
    public Car(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Звук двигателя");
    }

    public override void Desc()
    {
        Console.WriteLine("Автомобиль - транспортное средство");
    }
}

class Steamboat : Device
{
    public Steamboat(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Гудок парохода");
    }

    public override void Desc()
    {
        Console.WriteLine("Пароход - судно, двигаемое паровой машиной");
    }
}

class Program
{
    static void Main()
    {
        Kettle kettle = new Kettle("Чайник Philips");
        Microwave microwave = new Microwave("Микроволновка Samsung");
        Car car = new Car("Автомобиль Toyota");
        Steamboat steamboat = new Steamboat("Пароход Titanic");

        kettle.Show();
        kettle.Sound();
        kettle.Desc();

        Console.WriteLine();

        microwave.Show();
        microwave.Sound();
        microwave.Desc();

        Console.WriteLine();

        car.Show();
        car.Sound();
        car.Desc();

        Console.WriteLine();

        steamboat.Show();
        steamboat.Sound();
        steamboat.Desc();
    }
}