using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing.example.test
{
    public class Factorialservicetest
    {
        public void Testfactorialzero()
        {
            //Arrange
            FactorialService service = new FactorialService();

            //Act
            int results = service.Calculate(0);

            //Assert
            Assert.Equal(1, results);
            
        }
        public void Testfactorialfive()
        {
            FactorialService service = new FactorialService();

            int results = service.Calculate(5);

            Assert.Equal(120, results);

        }


    }
}
