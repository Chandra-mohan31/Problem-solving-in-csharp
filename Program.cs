namespace Task_24_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Personality trait application!");
            //personality trait application

            //general information
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the date you are born: ");

            string date = Console.ReadLine();
            Console.WriteLine("Enter your month you were born : ");

            string month = Console.ReadLine();
            Console.WriteLine("Enter the year you were born: ");

            string year = Console.ReadLine();   

            string Dob = date + "/" + month +"/" + year;

            //Be a mentalist

            Console.WriteLine("Are you an Introvert: yes//no\n");
            string isIntrovert = Console.ReadLine();
            Console.WriteLine("Are you a happy inside: yes//no\n");
            string isHappyInside = Console.ReadLine();
            Console.WriteLine("Rate yourself on the basis of peacefulness: 1-10\n");
            int peacefullnes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rate yourself on the basis of using social media: 1-10\n");
            int useOfSocialMedia = Convert.ToInt32(Console.ReadLine());


            if (isIntrovert == "yes" && isHappyInside == "yes")
            {
                Console.WriteLine("You are a happy person with genuine feelings!");
            }
            else if (isIntrovert == "yes" && isHappyInside == "no")
            {
                Console.WriteLine("You are Broken,dont worry things will get right!");
            }
            else if(isHappyInside == "yes" && peacefullnes > 5)
            {
                Console.WriteLine("You are a peacefull and will always be happy!");
            }else if(useOfSocialMedia >= 6)
            {
                Console.WriteLine("Do you honestly get value of it: yes//no\n");
                string resp = Console.ReadLine();
                if(resp == "yes" && peacefullnes > 5)
                {
                    Console.WriteLine("You are modern and with good self control!");
                }
            }

            //Mimic Ptolemy

            //Console.WriteLine("Lets find your Partner:\n");

            Console.WriteLine( $"Your zodiac sign : {zodiac_sign(12, month)}");



            //calendar man
            Console.WriteLine(CalculateAge(Convert.ToDateTime(Dob)));
            
        }
        static string CalculateAge(DateTime Dob)
        {
            DateTime Now = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;
            //Console.WriteLine("Years.." + Years);
            DateTime PastYearDate = Dob.AddYears(Years);
           

            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == Now)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= Now)
                {
                    Months = i - 1;
                    break;
                }
            }
            
            
            return $"Your current Age is : {Convert.ToString(Years)} years {Convert.ToString(Months)} months";
        }

        static string zodiac_sign(int day, string month)
        {
            string astro_sign = "";

            
            if (month == "12")
            {

                if (day < 22)
                    astro_sign = "Sagittarius";
                else
                    astro_sign = "capricorn";
            }

            else if (month == "1")
            {
                if (day < 20)
                    astro_sign = "Capricorn";
                else
                    astro_sign = "aquarius";
            }

            else if (month == "2")
            {
                if (day < 19)
                    astro_sign = "Aquarius";
                else
                    astro_sign = "pisces";
            }

            else if (month == "3")
            {
                if (day < 21)
                    astro_sign = "Pisces";
                else
                    astro_sign = "aries";
            }
            else if (month == "4")
            {
                if (day < 20)
                    astro_sign = "Aries";
                else
                    astro_sign = "taurus";
            }

            else if (month == "5")
            {
                if (day < 21)
                    astro_sign = "Taurus";
                else
                    astro_sign = "gemini";
            }

            else if (month == "6")
            {
                if (day < 21)
                    astro_sign = "Gemini";
                else
                    astro_sign = "cancer";
            }

            else if (month == "7")
            {
                if (day < 23)
                    astro_sign = "Cancer";
                else
                    astro_sign = "leo";
            }

            else if (month == "8")
            {
                if (day < 23)
                    astro_sign = "Leo";
                else
                    astro_sign = "virgo";
            }

            else if (month == "9")
            {
                if (day < 23)
                    astro_sign = "Virgo";
                else
                    astro_sign = "libra";
            }

            else if (month == "10")
            {
                if (day < 23)
                    astro_sign = "Libra";
                else
                    astro_sign = "scorpio";
            }

            else if (month == "11")
            {
                if (day < 22)
                    astro_sign = "scorpio";
                else
                    astro_sign = "sagittarius";
            }

            return astro_sign;
        }
    }
}