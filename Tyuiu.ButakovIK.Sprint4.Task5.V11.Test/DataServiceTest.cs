using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint4.Task5.V11.Lib;

namespace Tyuiu.ButakovIK.Sprint4.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] {  {-7, 6, 6, 6, 9,},
                                           {4, 4, 4, 9, 4,},
                                           {5, 5, 5, 6, 5,},
                                           {4, 9, 5, 9, 7,},
                                           {6, 9, 5, 6, 7,}, };


            int[,] wait = new int[5, 5] { {-7, 1, 1, 1, 1, },
                                         {1, 1, 1, 1, 1, },
                                         {1, 1, 1, 1, 1,},
                                         {1, 1, 1, 1, 1,},
                                         {1, 1, 1, 1, 1,}, };

            CollectionAssert.AreEqual(ds.Calculate(mas2), wait);
        }
    }
}
