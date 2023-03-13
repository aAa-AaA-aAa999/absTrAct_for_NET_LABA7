//Лабораторная работа №7
//Создать абстрактный класс "Транспорт", В котором определить абстрактные свойства "Скорость", "грузоподъемность", "Дальность расстояния", а также абстрактные методы возвращающие значения свойств. От этого класса
//создать абстрактные классы "Автомобиль", "Самолет", "Корабль" в которых реализованы свойства. Создать по одному классу от классов "Автомобиль", "Самолет", "Корабль".
//В которых реализованы свойстваа и методы, возвращающие значения свойств по типу
//<марка авто> грузоподъемностью в <грузоподъемность> может проехать <дальность расстояния>

﻿using System;
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
        return $"{ mark } грузоподъемностью { сapacity } кг может проехать { distance } км";
    }
}

abstract class Airplane : Transport
{
    public string mark { get; set; }
    public override string GetTransportInfo()
    {
        return $"{ mark } грузоподъемностью { сapacity } кг может пролететь { distance } км";
    }
}

abstract class Ship : Transport
{
    public string mark { get; set; }
    public override string GetTransportInfo()
    {
        return $"{ mark } грузоподъемностью { сapacity } кг может пройти { distance } км по воде";
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
