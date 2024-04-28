
class Programm
{
    public class Car
    {
        public string Model { get; set; }
        public Car(string model)
        {
            Model = model;
        }
    }
    public class Garage
    {
        private List<Car> cars;
        public Garage()
        {
            cars = new List<Car>();
        }
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public delegate void CarDelegate(Car car);
        public void WashAllCars(CarDelegate carDelegate)
        {
            foreach (Car car in cars)
            {
                carDelegate(car);
            }
        }
    }
    public class Washer
    {
        public void Wash(Car car)
        {
            Console.WriteLine($"Мойка машины марки: {car.Model}");
        }
    }
    public static void Main()
    {
        Car car1 = new Car("Audi");
        Car car2 = new Car("Chery");
        Car car3 = new Car("Toyota");

        Garage garage = new Garage();
        garage.AddCar(car1);
        garage.AddCar(car2);
        garage.AddCar(car3);

        Washer washer = new Washer();

        Garage.CarDelegate carDelegate = washer.Wash;
        garage.WashAllCars(carDelegate);
    }
}