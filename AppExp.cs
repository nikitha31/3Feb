using System;

namespace AppExp
{
    class AppExp
    {
        public void Divide(int a, int b)
        {


            int result = a / b;
            Console.WriteLine(result);


        }
        /// <summary>
        /// Add Function with Overflow Excedption. 
        /// </summary>
        public void Sub(int a, int b)
        {

            int result = a - b;

            Console.WriteLine(result);

        }
        public void Add(int a, int b)
        {


            int result = a + b;
            Console.WriteLine(result);

        }

        /// <summary>
        /// Multiplication Function with Overflow Excedption. 
        /// </summary>
        public void Mul(int a, int b)
        {

            int result = a * b;
            Console.WriteLine(result);


        }
        static void Main(string[] args)
        {
            //System Define Exception.
            AppExp appException = new AppExp();
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine("enter 2 nums");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            try
            {
                if ((x % 2 != 0) || (y % 2 != 0))
                {
                    throw new NotEvenException();
                }
                appException.Divide(x, y);
                appException.Sub(x, y);
                appException.Add(x, y);
                appException.Mul(x, y);

            }
            catch (NotEvenException e)
            {
                Console.WriteLine(e.Message);
            }
            //appException.Divide(x,y);
            //appException.Sub(x,y);
            //appException.Add(x,y);
            //appException.Mul(x,y);


        }
    }
    public class NotEvenException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "not even number";
            }
        }

    }

}
