using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_C_sharp_journey
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print Hellow world using the hello.cs class
            Console.WriteLine(HelloMessage.Get());
            int age= 25;
            Console.WriteLine($"I am {age} years old");

            long population = 7800000000L;
            Console.WriteLine($"The world population is approximately {population}");
            Console.WriteLine(population);
            Console.WriteLine(population.ToString("N0"));
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double pi = 3.14159D;
            Console.WriteLine($"The value of pi is approximately {pi}");
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.Epsilon);
            Console.WriteLine($"The maximum length of a double is {double.MaxValue} and the minimum length is {double.MinValue}");
            Console.ReadLine();

            // The above code demonstrates the use of various data types in C#, including int, long, and double. It also shows how to format numbers using ToString and how to access the maximum and minimum values of these data types.

            // In addition to the above, you can also explore other data types such as float, decimal, bool, char, and string. Each data type has its own range and precision, so it's important to choose the appropriate one based on your needs.
            // For example, if you need to store a large number with high precision, you might want to use the decimal data type instead of double. If you need to store a true or false value, you would use the bool data type. If you need to store a single character, you would use the char data type. And if you need to store a sequence of characters, you would use the string data type.
            // Overall, understanding data types is fundamental to programming in C#, as it allows you to effectively manage and manipulate data in your applications.

            //Below are examples of using other data types in C#:
            // Using float data type
            float temperature = 36.5F;
            Console.WriteLine($"The current temperature is {temperature} degrees Celsius");
            // Using decimal data type
            decimal price = 19.99M;
            Console.WriteLine($"The price of the item is {price} dollars");
            // Using bool data type
            bool isRaining = true;
            Console.WriteLine($"Is it raining? {isRaining}");
            // Using char data type
            char grade = 'A';
            Console.WriteLine($"The grade is {grade}");
            // Using string data type
            string name = "Alice";
            Console.WriteLine($"Hello, my name is {name}");

            // I hope this helps you on your C# journey! If you have any more questions or need further assistance, feel free to ask. Happy coding!
        }
    }
}
