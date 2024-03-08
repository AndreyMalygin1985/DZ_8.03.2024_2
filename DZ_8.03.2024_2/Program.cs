// Создать базовый класс «Устройство» и производные классы «Чайник», «Микроволновка», «Автомобиль»,
// «Пароход». С помощью конструктора установить имя каждого устройства и его характеристики.
//Реализуйте для каждого из классов методы:
//		■	Sound — издает звук устройства (пишем текстом в консоль);
//		■	Show — отображает название устройства;
//		■	Desc — отображает описание устройства.

using static System.Console;
class Device
{
    protected string name;

    public Device(string name)
    {
        this.name = name;
    }

    public virtual void Sound()
    {
        WriteLine("Звук устройства");
    }

    public void Show()
    {
        WriteLine("Название устройства: " + name);
    }

    public virtual void Desc()
    {
        WriteLine("Описание устройства");
    }
}

class Kettle : Device
{
    public Kettle(string name) : base(name)
    {
    }

    public override void Sound()
    {
        WriteLine("Шум кипящей воды");
    }

    public override void Desc()
    {
        WriteLine("Чайник - устройство для кипячения воды");
    }
}

class Microwave : Device
{
    public Microwave(string name) : base(name)
    {
    }

    public override void Sound()
    {
        WriteLine("Жужжание микроволновки");
    }

    public override void Desc()
    {
        WriteLine("Микроволновка - устройство для разогрева пищи");
    }
}

class Car : Device
{
    public Car(string name) : base(name)
    {
    }

    public override void Sound()
    {
        WriteLine("Звук двигателя");
    }

    public override void Desc()
    {
        WriteLine("Автомобиль - транспортное средство");
    }
}

class Steamboat : Device
{
    public Steamboat(string name) : base(name)
    {
    }

    public override void Sound()
    {
        WriteLine("Гудок парохода");
    }

    public override void Desc()
    {
        WriteLine("Пароход - судно, двигаемое паровой машиной");
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

        WriteLine();

        microwave.Show();
        microwave.Sound();
        microwave.Desc();

        WriteLine();

        car.Show();
        car.Sound();
        car.Desc();

        WriteLine();

        steamboat.Show();
        steamboat.Sound();
        steamboat.Desc();
    }
}