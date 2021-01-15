using System;

namespace PicoYPlacaPredictor
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Welcome to your predictor of Pico Y Placa.\nYou must enter the next information in the right format.");
            int platenumber = AskForPlateNumber();
            string date = AskForDate();
            string time = AskForTime();
            Calculate(platenumber, date, time);

        }
        //fill valida Plate Number
        private static int AskForPlateNumber()
        {
            //input  Plate Number
            Console.WriteLine("Plate Number (####): ");
            string plate = Console.ReadLine();
            int platenumber = 0;
            //validate length and int
            while (!(int.TryParse(plate, out platenumber) && plate.Length == 4))
            {
                Console.WriteLine("Set a valid Plate Number! (####)");
                plate = Console.ReadLine();
            }
            return platenumber;
        }
        
        //fill Formatted Date 
        private static string AskForDate()
        {
            //input Formatted Date
            Console.WriteLine("Date (yyyy/MM/dd): ");
            string date = Console.ReadLine();
            //validate length and valid string
            while (!(ValidateDate(date)))
            {
                Console.WriteLine("Set a valid Date! (yyyy/MM/dd)");
                date = Console.ReadLine();
            }
            return date;
        }
        
        //validate if the Console.ReadLine() is a valid date
        private static bool ValidateDate(string date)
        {
            if (date.Length == 10)
            {
                try
                {
                    DateTime oDate = Convert.ToDateTime(date);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        
        //fill Formatted Time 
        private static string AskForTime()
        {
            //input Formatted time
            Console.WriteLine("Time (HH:mm): ");
            string time = Console.ReadLine();
            //validate length and valid string
            while (!(ValidatTime(time)))
            {
                Console.WriteLine("Set a valid Time! (HH:mm)");
                time = Console.ReadLine();
            }
            return time;
        }
        
        //validate if the Console.ReadLine() is a valid time
        private static bool ValidatTime(string time)
        {
            if (time.Length == 5)
            {
                try
                {
                    string[] splitter = time.Split(':');
                    int horas = Convert.ToInt32(splitter[0]);
                    int minutos = Convert.ToInt32(splitter[1]);
                    if (!(horas <= 23 && horas >= 0))
                    {
                        return false;
                    }
                    if (!(minutos <= 59 && minutos >= 0))
                    {
                        return false;
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //calculate if the car can or cannot go to streets
        private static void Calculate(int platenumber, string date, string time)
        {
            throw new NotImplementedException();
        }

        

        
    }
}
