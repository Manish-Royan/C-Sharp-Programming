namespace WriteStatement
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Displaying Text
            Console.Write("Hey!");
            Console.WriteLine("Hello, World!");

            //Performing mathematical calculation
            Console.WriteLine(4 + 5);

            //Line Terminator
            Console.Out.NewLine = "\n"; // Set to newline character only

            //Printing Variables and Values
            string message = "\nKeep it up!";
            int number = 21;
            Console.WriteLine(message);
            Console.WriteLine("The number is: " + number);

            //Special Characters and String Formatting - C# provides various ways to format output using placeholders or string interpolation. 
            string name = "Manish";
            int age = 21;
            Console.WriteLine("Name: {0}, Age: {1}", name, age);
            Console.WriteLine($"Name: {name}, Age: {age}");

        }
    }
}
