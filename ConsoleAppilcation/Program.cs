using System.Reflection.Metadata.Ecma335;

namespace ConsoleAppilcation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p = "y";
            do {
                Console.Clear();
                headProgram("Kiattisk");
                // input รับค่าข้อมูล น้ำหนักและส่วนสูง
                double weight = 0.0;
                double height = 0.0;
                Console.Write("Input you weight(Kg) : ");
                weight = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input you height(Cm.) :");
                height = Convert.ToDouble(Console.ReadLine());
                line("-", 40);
                double heightM = 0;
                heightM = height / 100;
                bmi(weight,height);
                line("-", 40);
                p = "";
                Console.Write("Do you want to continue?(Y/N) : ");
                p = Convert.ToString(Console.ReadLine());

            } while (p == "y");

          
        }
        static void line(string letter, int width)
        {
            string str = "";
            for (int i = 0; i < width; i++)
            {
                str += letter;
            }
            Console.WriteLine(str);
        }
        static void headProgram(string programmerName)
        {
            Console.WriteLine("Body mass index (BMI)");
            line("-", 40);

            WriteLineColor("Develop dy "+programmerName, ConsoleColor.Red , ConsoleColor.Green );

            line("-", 40);
            Console.WriteLine("Please input you Information");
        }
        static void bmi(double weight, double heightM)
        {

            double Bmi = 0;
            Bmi = weight / Math.Pow(heightM, 2);
            string result = "";

            if (Bmi < 18.5)
            {
                result = "underweight(thin)";
            }
            else if (Bmi < 18.5 && Bmi < 24.9)
            {
                result = "normal weight(normal)";
            }
            else if (Bmi < 25 && Bmi < 29.9)
            {
                result = "overweight(fat)";
            }
            else
            {
                result = "obesity(Obesity)";
            }
            Console.WriteLine("Your Body mass index (BMI) is" + Bmi.ToString("0.00"));
            WriteLineColor("Your Body mass index (BMI) is" + Bmi, ConsoleColor.Blue, ConsoleColor.Green);
            Console.WriteLine("From your body mass indox, you are" + result);
            WriteLineColor("From your body mass indox, you are" + result, ConsoleColor.Black, ConsoleColor.Cyan);
        }
        static void WriteLineColor(string text, ConsoleColor fg, ConsoleColor bg) 
        { 
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bg;

            Console.WriteLine(text);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
