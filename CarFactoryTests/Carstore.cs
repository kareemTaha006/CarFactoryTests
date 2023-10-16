using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryTests
{
    public class Carstore
    {
        [Fact]
        public void AddCar_createCarAddtoStore_NotEmpltyStore()
        {

            CarStore carStore = new CarStore();
            Car car = new BMW();
            Car car1 = new BMW();
            car1.velocity = 1;

            carStore.AddCar(car);

         
            Assert.NotEmpty(carStore.cars);
        
            Assert.DoesNotContain<Car>(car1, carStore.cars);
        }
    }
}
