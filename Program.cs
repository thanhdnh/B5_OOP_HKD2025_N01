﻿public class Vehicle : ICloneable{
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
/*
    1. Khai báo một interface IVector gồm có các phương thức:
        - Add(IVector vector): IVector
        - Subtract(IVector vector): IVector
        - Multiply(double scalar): IVector
        - Divide(double scalar): IVector
        - Length(): double
        - Normalize(): IVector
        - DotProduct(IVector vector): double
        - CrossProduct(IVector vector): IVector
        để thực thi các chức năng: cộng 2 vector, trừ 2 vector, nhân vector với một số, 
        chia vector cho một số, tính độ dài vector, chuẩn hóa vector (chia từng thành phần cho độ dài của vector, 
        tích vô hướng, tích có hướng.
    2. Khai báo một lớp Vector2D và Vector3D kế thừa từ IVector và thực thi các phương thức của IVector.
    3. Trong hàm main, tạo ra một List các IVector và triệu gọi hàm tạo của Vector2D và Vector3D ngẫu nhiên cho từng
    phần tử trong List. Sau đó triệu gọi các phương thức tương ứng của IVector cho từng phần tử trong List.
    4. Cho phép Vector2D và Vector3D thực thi bổ sung 2 interface ICloneable và IComparable. Với IComeparable, các vector
    có thể so sánh với nhau dựa trên độ dài của nó (thông qua Length). Sắp xếp các vector trong List của câu 3 theo
    thứ tự tăng dần của độ dài. In ra dưới dạng bảng toạ độ các vector (x, y, z) và độ dài tương ứng.
    5. Bổ sung vào lớp Vector2D một phương thức ConvertToVector3D() để chuyển đổi từ Vector2D sang Vector3D. Trong đó, có
    sử dụng đến phương thức Clone() để tạo ra một bản sao của Vector2D trước khi chuyển đổi.
*/
