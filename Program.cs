public class Vehicle : ICloneable{
    public double MaxVelocity { get; set; } = 0.0;
    public Vehicle() {}
    public Vehicle(Vehicle vehicle) {  MaxVelocity = vehicle.MaxVelocity; }
    public object Clone() {   return new Vehicle(this);  }
}

public class Car : Vehicle {
    public int NumberOfWheels { get; set; } = 0;
    public Car() {}
    public Car(Car car) : base(car) { NumberOfWheels = car.NumberOfWheels; }
    public new object Clone() {  return new Car(this);   }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        ICloneable vehicle = new Vehicle();
        ICloneable car = new Car();

        Vehicle vehicleClone = (Vehicle)vehicle.Clone();
        Car carClone = (Car)car.Clone();
    }
}
/* Lab 05 */
