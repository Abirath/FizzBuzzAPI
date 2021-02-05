using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FizzBuzzAPI.Models
{
    public static class ModelBuilderExtensions
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            List<FizzBuzzStore> dataList = new List<FizzBuzzStore>();

            int a = 3, b = 5, n = 100;
            for (int i = 1; i <= n; i++)
            {
                if (i % a == 0 && !((i % a == 0) && (i % b == 0)))
                {
                    dataList.Add(new FizzBuzzStore { FizzBuzzStoreID = i ,FizzBuzzValue = "Fizz"});
                }
                else if (i % b == 0 && !((i % a == 0) && (i % b == 0)))
                {
                    dataList.Add(new FizzBuzzStore { FizzBuzzStoreID = i, FizzBuzzValue = "Buzz" });
                }
                else if ((i % a == 0) && (i % b == 0))
                {
                    dataList.Add(new FizzBuzzStore { FizzBuzzStoreID = i, FizzBuzzValue = "FizzBuzz" });
                }
                else
                {
                    dataList.Add(new FizzBuzzStore { FizzBuzzStoreID = i, FizzBuzzValue = i.ToString() });
                }

            }

            modelBuilder.Entity<FizzBuzzStore>().HasData(dataList);
        }
    }
}
