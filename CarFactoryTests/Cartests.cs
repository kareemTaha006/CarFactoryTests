using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryTests
{
    public class Cartests
    {
        [Fact]
        public void NewCar_CarTypeBMWComparewithAnotherBMW_equals()
        {

            BMW bmw = new BMW();


            var result = CarFactory.NewCar(CarTypes.Toyota);


            Assert.Equal(bmw, result);
         
        }
        [Fact]
        public void NewCar_CarTypeAudi_Null()
        {
       

           
            var result = CarFactory.NewCar(CarTypes.Audi);

        
            Assert.Null(result);
        }

        [Fact]
        public void NewCar_CarTypeToyota_ObjectFromToyota()
        {
           
            var result = CarFactory.NewCar(CarTypes.Toyota);

        
            Assert.IsType<Toyota>(result);
           
        }

    }

}
