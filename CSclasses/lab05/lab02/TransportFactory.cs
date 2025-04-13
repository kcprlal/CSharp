using System;

abstract class TransportFactory
{
    protected string travelMode = "quickest"; // initial value

    public string TravelMode
    {
        get { return travelMode; }
        set
        {
            if (value == "quickest" || value == "cheapest" || value == "convenient")
                travelMode = value;
            else
                Console.WriteLine($"Unrecognized travel mode: {value}");
        }
    }

    public abstract Vehicle2 CreateVehicle();
    public abstract Ticket CreateTicket();
}

abstract class Vehicle2 { }
abstract class Ticket { }

class Metro : Vehicle2 { }
class Bike2 : Vehicle2 { }
class Car2 : Vehicle2 { }
class Train2 : Vehicle2 { }
class Bus2 : Vehicle2 { }

class BusTicket : Ticket { }
class MetroTicket : Ticket { }
class TrainTicket : Ticket { }

class UrbanTransportFactory : TransportFactory
{
    public override Vehicle2 CreateVehicle()
    {
        if (travelMode == "quickest")
            return new Metro();
        else if (travelMode == "cheapest")
            return new Bike2();
        else if (travelMode == "convenient")
            return new Car2();
        else
            return null;
    }

    public override Ticket CreateTicket()
    {
        if (travelMode == "quickest")
            return new MetroTicket();
        else if (travelMode == "cheapest" || travelMode == "convenient")
            return null; // Bike and Car don't use tickets
        else
            return null;
    }
}

// Międzymiastowa fabryka
class IntercityTransportFactory : TransportFactory
{
    public override Vehicle2 CreateVehicle()
    {
        if (travelMode == "quickest" || travelMode == "convenient")
            return new Train2();
        else if (travelMode == "cheapest")
            return new Bus2();
        else
            return null;
    }

    public override Ticket CreateTicket()
    {
        if (travelMode == "quickest" || travelMode == "convenient")
            return new TrainTicket();
        else if (travelMode == "cheapest")
            return new BusTicket();
        else
            return null;
    }
}
