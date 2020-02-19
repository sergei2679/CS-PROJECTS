using System;

namespace Exersice_56
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();             //  class  Car
            Car[] carArray = new Car[8];   
            
            carArray[0]=new Car() { };

            carArray[1] = new Car() { licenseCode = 100, manufacturer = "mazda", model = "6", speedometer = 30000, color = "white", isHaveBreackingSystem = true };
            carArray[2] = new Car() { licenseCode = 100, manufacturer = "mazda", model = "6", speedometer = 30000, color = "white", isHaveBreackingSystem = true };
            carArray[3] = new Car() { licenseCode = 333, manufacturer = "opel", model = "astra", speedometer = 37800, color = "black", isHaveBreackingSystem = true };
            carArray[4] = new Car() { licenseCode = 222, manufacturer = "toyota", model = "corolla", speedometer = 50030, color = "silver", isHaveBreackingSystem = true };
            carArray[5] = new Car() { licenseCode = 555, manufacturer = "subaru", model = "impresa", speedometer = 270800, color = "white", isHaveBreackingSystem = false };
            carArray[6] = new Car() { licenseCode = 555, manufacturer = "subaru", model = "impresa", speedometer = 270800, color = "white", isHaveBreackingSystem = false };
            carArray[7] = new Car() { licenseCode = 555, manufacturer = "subaru", model = "impresa", speedometer = 270800, color = "white", isHaveBreackingSystem = false };

            Console.WriteLine(" ----- All Cars class -----");

            for (int i = 0; i < carArray.Length; i++)
            {
                Console.WriteLine(carArray[i].toString());
            }
          

            Console.WriteLine(" \n ----- Car with max speedometer value -----");
           
            Console.WriteLine(" \n " + c.getMaxSpeedCar(carArray).licenseCode + 
                               " , " + c.getMaxSpeedCar(carArray).manufacturer + 
                               " , " + c.getMaxSpeedCar(carArray).speedometer);


            Console.ReadLine();
        }
       

    }
}
