using System;
abstract class Transport
{
    public abstract double speed { get; }
    public abstract double сapacity { get; }
    public abstract double distance { get; }

    public abstract string GetTransportInfo();
}

abstract class Automobile : Transport
{
    public string mark { get; set; }
    public override string GetTransportInfo()
    {
        return $"{mark} грузоподъемностью {сapacity} кг может проехать {distance} км";
    }
}

abstract class Airplane : Transport
{
    public string mark { get; set; }
    public override string GetTransportInfo()
    {
        return $"{mark} грузоподъемностью {сapacity} кг может пролететь {distance } км";
    }
}

abstract class Ship : Transport
{
    public string mark { get; set; }
    public override string GetTransportInfo()
    {
        return $"{mark} грузоподъемностью {сapacity} кг может пройти {distance} км по воде";
    }
}

class Matiz : Automobile
{
    public override double speed => 60;
    public override double сapacity => 250;
    public override double distance => 400;

    public Matiz()
    {
        mark = "Matiz";
    }
}

class Ogyrchik : Airplane
{
    public override double speed => 1200;
    public override double сapacity => 4000;
    public override double distance => 30000;

    public Ogyrchik()
    {
        mark = "Ogyrchik";
    }
}

class Cabrina : Ship
{
    public override double speed => 40;
    public override double сapacity => 1000;
    public override double distance => 2500;

    public Cabrina()
    {
        mark = "Cabrina";
    }
}

class Program
{
    static void Main()
    {
        Matiz matiz = new Matiz();
        Console.WriteLine(matiz.GetTransportInfo());

        Ogyrchik ogyrchik = new Ogyrchik();
        Console.WriteLine(ogyrchik.GetTransportInfo());

        Cabrina cabrina = new Cabrina();
        Console.WriteLine(cabrina.GetTransportInfo());
    }
}