using System;
using System.Collections.Generic;
using System.Text;

namespace PicoYPlacaPredictor
{
    public class Methods
    {
        public static int DayOfLastDigitPlate(int plateNumber)
        {
            //get last digit of the plate
            int last = plateNumber % 10;
            //get Day according to DateTime.DayOfWeek Property using in the VerifyDayOnDate function 
            //Monday 1(Plates 1/2)
            //Tuesday 2 (Plates 3/4)
            //Wednesday 3 (Plates 5/6)
            //Thursday 4 (Plates 7/8)
            //Friday 5 (Plates 9/0)
            if (last==1 || last ==2)
            {
                return 1;
            }
            else if (last == 3 || last == 4)
            {
                return 2;
            }
            else if (last == 5 || last == 6)
            {
                return 3;
            }
            else if (last == 7 || last == 8)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }
        public static int VerifyDayOnDate(string date)
        {
            //Parse the string formatted Date to a DateTime object
            DateTime dateF = DateTime.Parse(date);
            //get the dayofweek of the DateTime object
            int dayondate = (int) dateF.DayOfWeek;
            return dayondate;
        }
        public static bool VerifyTime(string time)
        {
            //split the string time
            string[] splitterTime = time.Split(':');
            //splitter[0] horas
            //splitter[1] minutos
            int hours = int.Parse(splitterTime[0]);
            int minutes = int.Parse(splitterTime[1]);
            //set the ranges of PicoYPlaca Restriction 
            //Hours: 7:00 - 9:30 / 16:00 - 19:30
            if ((hours<=9 && hours >=7) || (hours <= 19 && hours >= 16))
            {
                //validate the 30 minutos of 9 and 19
                if (hours==9 || hours ==19)
                {
                    if (minutes <= 30)
                    {
                        //true = in the restriction's time
                        return true;
                    }
                    else
                    {
                        //false = not in the restriction's time
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool CanRoad(PicoPlaca obj)
        {
            int dayOfPlate = DayOfLastDigitPlate(obj.NumberPlate);
            int dayOfDate = VerifyDayOnDate(obj.FormattedDate);
            bool TimeRestriction = VerifyTime(obj.FormattedTime);
            //Calculate if the day of plate and the day of date are the same
            bool dayAndPlateEqual;
            if (dayOfPlate==dayOfDate)
            {
                dayAndPlateEqual = true;
            }
            else
            {
                dayAndPlateEqual = false;
            }
            //validate if dayAndPlateEqual and TimeRestriction are true then car cant road, else car cant road
            if (TimeRestriction && dayAndPlateEqual)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}
