namespace Conversion;

class Conversion
{
    private static void Main(string[] args)
    {
        char car = 'F';
        //member variables
        string choice;
        int response = 0;
        double numMeters = 0.00;

        //This do while loop checks to see if
        //the number the user entered is less than
        //0 while the number of meters is less than
        //or equal to 0.
        do
        {


            Console.WriteLine($"I will convert distance into a choice of measurements.\nEnter a distance in meters:");
            double.TryParse(Console.ReadLine(), out numMeters);
            if (numMeters < 0)
            {
                Console.WriteLine("Cannot be a negative number");
            }
        } while (numMeters <= 0);
        Console.WriteLine("I will convert distance into a choice of measurements.");

        //Method for the menu of different conversions
        static void Menu()
        {
            Console.WriteLine($"1. Convert to Kilometers\n2. Convert to Inches\n3. Convert to Feet\n0. Quit the program");
        }


        //Method for converting to kilometers
        static void ShowKilometers(double numMeters)
        {
            double kilometers = numMeters * 0.001;
            Console.WriteLine($"kilometers: {Math.Round(kilometers, 3)}");
        }


        //Method for converting to inches
        static void ShowInches(double numMeters)
        {

            double inches = numMeters * 39.97;
            Console.WriteLine($"Inches: {Math.Round(inches, 3)}");
        }


        //Method for converting to inches
        static void ShowFeet(double numMeters)
        {
            double feet = numMeters * 3.281;
            Console.WriteLine($"Feet: {Math.Round(feet, 3)}");
        }

        //do while loop that asks the user for their conversion choice
        //then based on whatever choice the user inputs, it will print out
        //the conversion while users choice doesn't equal 0
        //using a switch statement.
        do
        {

            Console.WriteLine("Please enter your choice");
            Menu();
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowKilometers(numMeters);

                    break;

                case "2":
                    ShowInches(numMeters);
                    break;

                case "3":
                    ShowFeet(numMeters);
                    break;

                case "0":
                    return;
            }
        } while (choice != "0");


        if (car != 'F')
        {

        }
}