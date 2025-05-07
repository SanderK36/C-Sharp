namespace condition_Intro
{
    internal class Program
    {
        static int numOne = 3;
        static int numTwo = 2;
        static int numThree = 1;
        static int numFour = 4;
        static int numFive = 20;
        static int numSix = 10;
        static bool isEqual = true;
        static void Main(string[] args)
        {
            checkNum();
            checkNum2();
            checkNum3();
        }
        //Oppgave 1
        public static void checkNum()
        {
            if(numOne == numTwo)
            {
                isEqual = true;
                Console.WriteLine("Nummerene er like");
            }
            else
            {
                isEqual = false;
                Console.WriteLine("Nummerene er ikke like");
            }
        }
        //Oppgave 2
        public static void checkNum2()
        {
            if(numThree != numFour)
            {
                Console.WriteLine($"{numThree} er ikke lik {numFour} svaret er {numThree + numFour}");
            }
            else if(numThree == numFour)
            {
                Console.WriteLine($"{numThree} er lik {numFour} svaret er {numThree * numFour}");
            }

        }
        //Oppgave 3
        public static void checkNum3()
        {
            if(numFive + numSix == 30)
            {
                Console.WriteLine(isEqual);
            }
            else if(numFive + numSix != 30)
            {
                Console.WriteLine(!isEqual);
            }
        }
    }
}
