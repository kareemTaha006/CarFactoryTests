using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryTests
{

    public class ToyataTests
    {
        [Fact]
        public void isstoped_Velocity0_True()
        {
            Toyota toyota = new Toyota();
            toyota.velocity = 0;

            var result=toyota.IsStopped();

            Assert.True(result);

        }
        [Fact]
        public void Accelerate_CarToyotavilocity5_10()
        {
    
            Toyota toyota = new Toyota();
            toyota.velocity = 5;

 
            toyota.Accelerate();

        
            Assert.Equal(10, toyota.velocity);
        }

        [Fact]
        public void GetDirection_DirectionForward_Forward()
        {
          
            Toyota toyota = new Toyota();
            toyota.drivingMode = DrivingMode.Backward;

     
            var result = toyota.GetDirection();


            Assert.Equal("Backward", result);

        }

    }
}
