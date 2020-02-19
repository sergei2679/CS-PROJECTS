
namespace Exersice_56
{
    public class Car
    {
        private int count = 0;        //  using only in this scope
        public int maxSpeedometer = 0;
        //public int minSpeedometer = 0;

        public int licenseCode;
        public string manufacturer;
        public int speedometer;
        public string color;
        public string model;
        public bool isHaveBreackingSystem;

        public Car() { }

        public void AddCar(int licenseCode,
                           string manufacturer,
                           int speedometer,
                           string color,
                           string model,
                           bool isHaveBreackingSystem)
        {
            if (speedometer > maxSpeedometer || count == 0)
                maxSpeedometer = speedometer;

            count++;
        }

        public Car getMaxSpeedCar(Car[] cars)
        {
            int max = 0;
            maxSpeedometer = cars[0].speedometer;

            for (int i = 1; i < cars.Length; i++)
            {
                if (cars[i].speedometer > maxSpeedometer)
                {
                    maxSpeedometer = cars[i].speedometer;
                    max = i;
                }
            }
            return cars[max];
        }

        public Car listCarsByMaxSpeed(int maxSpeed)
        {
            Car c;
            c = new Car();
            return c;
        }
        public int countMaxSpeed(int maxSpeed, Car[] cars)
        {
            int count = 0;
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].speedometer == maxSpeed)
                    count++;
            }
            return count;
        }

        public string toString()
        {
            return "\n License Code : " + licenseCode +
                   "\n Manufacturer : " + manufacturer +
                   "\n Model : " + model +
                   "\n Speedometer : " + speedometer + " km" +
                   "\n Color : " + color +
                   "\n Have Breacking System : " + isHaveBreackingSystem + 
                   "\n ----------------------------------------------------";
        }

        struct objectCar
        {
            public int licenseCode;
            public string manufacturer;
            public int speedometer;
            public string color;
            public string model;
            public bool isHaveBreackingSystem;
            public objectCar(
                                int licenseCode,
                                string manufacturer,
                                int speedometer,
                                string color,
                                string model,
                                bool isHaveBreackingSystem

                            )
            {
                this.licenseCode = licenseCode;
                this.manufacturer = manufacturer;
                this.speedometer = speedometer;
                this.color = color;
                this.model = model;
                this.isHaveBreackingSystem = isHaveBreackingSystem;
            }
        }

        struct Location
        {
            public int x, y;
            public Location(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}