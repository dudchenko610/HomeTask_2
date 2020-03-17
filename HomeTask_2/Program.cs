using HomeTask_2.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace HomeTask_2
{
    class Program
    {
        static void Main(string[] args)
        {


            /**TASK 1, 2**/

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(fibonachiLoop(i) + "");
            }

            int f = factorialRec(7);
            Console.WriteLine("Factorial rec = " + f);


           
            Console.WriteLine("Factorial loop = " + f);
            f = fibonachiLoop(5);
            Console.WriteLine("Fibonachi loop = " + f);
            f = fibonachiRec(5);
            Console.WriteLine("Fibonachi rec = " + f);

            /**TASK 3**/

            Console.WriteLine("_____");

            List<MyCrazyModel> list = new List<MyCrazyModel>();

            Random r = new Random();
            for (int i = 0; i < 15; i ++) 
            {
                MyCrazyModel model = new MyCrazyModel { propertyInt = i, propertyEnum =  r.NextDouble() < 0.3 ? SomeEnum.Item1 : (r.NextDouble() < 0.6 ? SomeEnum.Item2 : SomeEnum.Item3) };
                list.Add(model);

                Console.WriteLine("i = " + i + " property = " + model.propertyEnum);
            }

            IEnumerable<MyCrazyModel> mdls = list.Where(i => i.propertyEnum == SomeEnum.Item1);

            IEnumerable<IGrouping<SomeEnum, MyCrazyModel>> listWithItem1 = list.GroupBy(i => i.propertyEnum);

            Console.WriteLine("_____");

            foreach (MyCrazyModel m in mdls) 
            {
                Console.WriteLine("i = " + m.propertyInt + " property = " + m.propertyEnum);
            }

            Console.WriteLine("_____");

            foreach (IGrouping<SomeEnum, MyCrazyModel> group in listWithItem1)
            {

                Console.WriteLine("Key = " + group.Key);

                foreach (MyCrazyModel m in group) 
                {
                    Console.WriteLine("i = " + m.propertyInt + " property = " + m.propertyEnum);
                }
                
            }


            /**TASK 4**/

            string line = "";
            int[] array = new int[20];
            for (int i = 0; i < 20; i ++) {
                array[i] = r.Next(1, 20);

                line += array[i] + ", ";
                

            }

            Console.WriteLine(line);

            IEnumerable<IGrouping<int, int>> listNumbers = array.GroupBy(i => i % 2);

            Console.WriteLine("_____");
            Console.WriteLine("_____");
            Console.WriteLine("_____");



            foreach (IGrouping<int, int> group in listNumbers) 
            {

                Console.WriteLine("Key = " + group.Key);
                line = "";
                foreach (int i in group) 
                {
                    line += i + ", ";
                    
                }

                Console.WriteLine(line);
            }



        }



        static int fibonachiRec(int n) {

            if (n == 1 || n == 0) {
                return 1;
            }

            return fibonachiRec(n - 2) + fibonachiRec(n - 1);
        }

        static int fibonachiLoop(int n) {

            if (n == 1) {
                return 0;
            }

            if (n == 2 || n == 3)
            {
                return 1;
            }


            int res = 1;
            int preceding = 1;
            int p;

            for (int i = 3; i < n; i ++) {
                p = preceding;
                preceding = res;
                res += p;

            }

            return res;
            
        }

        static int factorialLoop(int n) 
        {
            int res = 1;

            for (int i = 2; i <= n; i ++) {
                res *= i;
            }

            return res;
        }

        static int factorialRec(int n)
        {

            if (n == 1) {
                return 1;
            }

            return factorialRec(n - 1) * n;

        }

    }

    
}
