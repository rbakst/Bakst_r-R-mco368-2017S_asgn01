using PresidentialEligibilityCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Boolean citizen;
            int yearOfBirth;
            int yearsResided;
            int termsServed;
            Boolean impeached;
            Boolean rebelled;

            if (args.Length == 0)
            {
                citizen = CheckCitizen();

                yearOfBirth = GetYearOfBirth();

                yearsResided = GetYearsResided();

                termsServed = GetTermsServed();

                impeached = CheckImpeached();

                rebelled = GetRebelled();
            }

            else if (args.Length == 6)
            {
                if (args[0][0] == 'Y'|| args[0][0] == 'y')
                    citizen = true;
                else if (args[0][0] == 'N'|| args[0][0] == 'n')
                    citizen = false;
                else
                    throw new Exception();
                string birthString = args[1];
                Int32.TryParse(birthString, out yearOfBirth);
                string yearsString = args[2];
                Int32.TryParse(yearsString, out yearsResided);
                string termsString = args[3];
                Int32.TryParse(termsString, out termsServed);

                if (args[4][0] == 'Y'|| args[4][0] == 'y')
                    impeached = true;
                else if (args[4][0] == 'N'|| args[4][0] == 'n')
                    impeached = false;
                else
                    throw new Exception();

                if (args[5][0] == 'Y'|| args[5][0] == 'y')
                    rebelled = true;
                else if (args[5][0] == 'N'||args[5][0] == 'n')
                    rebelled = false;
                else
                    throw new Exception();
            }
            else
            {
                throw new Exception();
            }

            PresidentialEligibility pE = new PresidentialEligibility(citizen, yearOfBirth, yearsResided,
                termsServed, impeached, rebelled);
            if (pE.isEligible())
            {
                Console.WriteLine("Eligible to be President of US");
            }
            else
            {
                Console.WriteLine("Not eligible to be President of US");
            }
            Console.ReadKey();
        }



        public static Boolean CheckCitizen()
        {
            String input = null;
            Boolean citizen = false;
            while (input == null)
            {
                Console.WriteLine("Are you a citizen of the US? (Y/N) ");
                input = Console.ReadLine().ToUpper();
                if (input[0] == 'Y')
                {
                    citizen = true;
                }
                else if (input[0] == 'N')
                {
                    citizen = false;
                }
                else
                {
                    Console.WriteLine("Must enter Y/N");
                }
            }
            return citizen;
        }

        public static int GetYearOfBirth()
        {
            Boolean boolVal = false;
            int yearOfBirth = 0;
            while (boolVal == false)
            {
                Console.WriteLine("Year of Birth: ");
                boolVal = int.TryParse(Console.ReadLine(), out yearOfBirth);
            }
            return yearOfBirth;
        }

        public static int GetYearsResided()
        {
            Boolean boolVal = false;
            int yearsResided = 0;
            while (boolVal == false)
            {
                Console.WriteLine("How many years have you resided in the US?");
                boolVal = int.TryParse(Console.ReadLine(), out yearsResided);
            }
            return yearsResided;
        }

        private static int GetTermsServed()
        {
            Boolean boolVal = false;
            int termsServed = 0;
            while (boolVal == false)
            {
                Console.WriteLine("How many terms have you served? ");
                boolVal = int.TryParse(Console.ReadLine(), out termsServed);
            }
            return termsServed;
        }

        public static Boolean CheckImpeached()
        {
            String input = null;
            Boolean impeached = false;
            while (input == null)
            {
                Console.WriteLine("Have you ever been impeached? (Y/N)");
                input = Console.ReadLine().ToUpper();
                if (input[0] == 'Y')
                {
                    impeached = true;
                }
                else if (input[0] == 'N')
                {
                    impeached = false;
                }
                else
                {
                    Console.WriteLine("Must enter Y or N");
                }
            }
            return impeached;
        }

        public static Boolean GetRebelled()
        {
            String input = null;
            Boolean rebelled = false;

            while (input == null)
            {
                Console.WriteLine("Have you ever rebelled against the US?");
                input = Console.ReadLine().ToUpper();
                if (input[0] == 'Y')
                {
                    rebelled = true;
                }
                else if (input[0] == 'N')
                {
                    rebelled = false;
                }
                else
                {
                    Console.WriteLine("Must enter Y or N");
                }
            }
            return rebelled;
        }


    }
}
