using System;

namespace SysException
{
    class Program
    {
            /// <summary>
            /// Divide Function with DivideByZeroException Excedption. 
            /// </summary>
            public void Divide()
            {
                try
                {
                    Console.WriteLine("Enter  2 numbers");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine()); ;
                    int result = a / b;
                    Console.WriteLine(result);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
            /// <summary>
            /// Add Function with Overflow Excedption. 
            /// </summary>
        public void Sub()
        {
            try
            {
                Console.WriteLine("Enter any 2 numbers");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine()); ;
                int result;
                checked
                {
                    result = a - b;
                    Console.WriteLine(result);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
        public void Add()
            {
                try
                {
                    Console.WriteLine("Enter any 2 numbers");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine()); ;
                    int result;
                    checked
                    {
                        result = a + b;
                        Console.WriteLine(result);
                    }
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
            }

            /// <summary>
            /// Multiplication Function with Overflow Excedption. 
            /// </summary>
            public void Mul()
            {
                try
                {
                    Console.WriteLine("Enter any 2 numbers");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine()); ;
                    int result;
                    checked
                    {
                        result = a * b;
                        Console.WriteLine(result);
                    }
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
            }
            static void Main(string[] args)
        {
            //System Define Exception.
            Program systemException = new Program();
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            systemException.Divide();
            systemException.Sub();
            systemException.Add();
            systemException.Mul();

            
        }
    }

      
}
