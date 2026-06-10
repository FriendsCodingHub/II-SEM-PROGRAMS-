using System;

class Building
{
    public int Floors;
    public int Area;
    public int Occupants;

    // Parameterized constructor
    public Building(int f, int a, int o)
    {
        Floors = f;
        Area = a;
        Occupants = o;
    }

    // Area per person
    public int AreaPerPerson()
    {
        return Area / Occupants;
    }

    // Maximum occupants based on minimum area
    public int MaxOccupant(int minArea)
    {
        return Area / minArea;
    }
}

class BuildingDemo
{
    static void Main()
    {
        Building house = new Building(2, 2500, 4);
        Building office = new Building(3, 4200, 25);

        Console.WriteLine("House Floors: " + house.Floors);
        Console.WriteLine("Office Floors: " + office.Floors);

        Console.WriteLine("House Area Per Person: " + house.AreaPerPerson());
        Console.WriteLine("Office Area Per Person: " + office.AreaPerPerson());

        Console.WriteLine("Max Occupants for House: " + house.MaxOccupant(300));
        Console.WriteLine("Max Occupants for Office: " + office.MaxOccupant(300));
    }
}