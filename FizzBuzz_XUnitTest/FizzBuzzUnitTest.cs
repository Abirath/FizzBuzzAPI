using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FizzBuzzAPI.Models;
using FizzBuzzAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz_XUnitTest
{
    public class FizzBuzzUnitTest
    {
        private FizzBuzzDBContext context;

        [Fact]
        public void GetFizzBuzz_Return_OkResultAndFizzValueForThree() 
        {
            var model = new FizzBuzzStore { FizzBuzzStoreID = 3, FizzBuzzValue = "Fizz" };
            var controller = new FizzBuzzController(context);
           
            var data = controller.FizzBuzz();

            Assert.IsType<OkObjectResult>(data.Find(x=> x.FizzBuzzStoreID == 3));
        }

        [Fact]
        public void GetFizzBuzz_Return_OkResultAndBuzzValueForFive()
        {
            var model = new FizzBuzzStore { FizzBuzzStoreID = 5, FizzBuzzValue = "Buzz" };
            var controller = new FizzBuzzController(context);

            var data = controller.FizzBuzz();

            Assert.IsType<OkObjectResult>(data.Find(x => x.FizzBuzzStoreID == 5));
        }

        [Fact]
        public void GetFizzBuzz_Return_OkResultAndFizzBuzzValueForFifteen()
        {
            var model = new FizzBuzzStore { FizzBuzzStoreID = 15, FizzBuzzValue = "FizzBuzz" };
            var controller = new FizzBuzzController(context);

            var data = controller.FizzBuzz();

            Assert.IsType<OkObjectResult>(data.Find(x => x.FizzBuzzStoreID == 15));
        }
    }
}
