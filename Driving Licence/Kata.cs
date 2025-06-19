using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CodeWars
{
    class Kata
    {
        public string driver(params string[] data)
        {
            bool middleNameIsPresent = data[1] != "";

            string firstname = data[0];
            string surname = data[2];

            string[] birthdate = data[3].Split('-');
            birthdate[1] = monthToNumber(birthdate[1]);

            string gender = data[4];

            string driverLiscence = "";

            for (int i = 0; i < 5; i++)
            {
                if(surname.Length - 1 >= i)
                {
                    driverLiscence += surname[i].ToString().ToUpper();
                } else
                {
                    driverLiscence += "9";
                }
            }

            driverLiscence += birthdate[2][2];
            
            if(gender == "F")
            {
                birthdate[1] = $"{int.Parse(birthdate[1][0].ToString()) + 5}" + birthdate[1][1];

                string day = birthdate[0].Length == 1 ? "0" + birthdate[0] : birthdate[0];
                
                //birthdate[0] = $"{int.Parse(day[0].ToString()) + 5}" + day[1];
            }

            driverLiscence += birthdate[1];
            driverLiscence += birthdate[0];
            driverLiscence += birthdate[2][3];
            driverLiscence += firstname.ToUpper()[0];
            driverLiscence += middleNameIsPresent ? data[1].ToUpper()[0] : "9";
            driverLiscence += "9";
            driverLiscence += "AA";


            return driverLiscence;
        }

        public static int[] birthdayToIntArray(string[] birthday) => [int.Parse(birthday[0]), int.Parse(birthday[2])];
        public static string monthToNumber(string month)
        {
            string number;

            switch(month.ToLower())
            {
                case "january" or "jan":
                    number = "01";
                    break;
                case "february" or "feb":
                    number = "02";
                    break;
                case "march" or "mar":
                    number = "03";
                    break;
                case "april" or "apr":
                    number = "04";
                    break;
                case "may":
                    number = "05";
                    break;
                case "june" or "jun":
                    number = "06";
                    break;
                case "july" or "jul":
                    number = "07";
                    break;
                case "august" or "aug":
                    number = "08";
                    break;
                case "september" or "sep":
                    number = "09";
                    break;
                case "october" or "oct":
                    number = "10";
                    break;
                case "november" or "nov":
                    number = "11";
                    break;
                case "december" or "dec":
                    number = "12";
                    break;
                default:
                    number = month;
                    break;
            }

            return number;
        }
    }
}
