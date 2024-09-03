// A class that has two methods for converting input to an integer or a double

public class ConvertingInput
{

    // Sunt foarte bune metodele, doar ca ambele folosesc cam acelasi cod. 
    // Dupa ce mai faci din cursul de C#, arunca un ochi peste codul asta
    // si spune-mi de crezi de Virtual Methods, poate crezi ca o sa fie o 
    // implementare mai buna cu ele.
    
    public int ConvertToInt(string message)
    {
        bool validInput = false;
        int result = 0;

        while (!validInput)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine(message);
            string input = Console.ReadLine();

            try
            {
                result = Convert.ToInt32(input);
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("The input format is invalid. Please enter a valid number.");
            }
        }
        return result;
    }

    public double ConvertToDouble(string message)
    {
        bool validInput = false;
        double result = 0;

        while (!validInput)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine(message);
            string input = Console.ReadLine();

            try
            {
                result = (int)Convert.ToDouble(input);
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("The input format is invalid. Please enter a valid number.");
            }
        }
        return result;
    }

}

