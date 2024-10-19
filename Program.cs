
namespace GeometryGuru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this console app checks your knowledge!!!");
            Console.WriteLine("1. equilateral triangle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine();
            Console.Write("choose shape: ");

            Random random = new Random();
            int option = 0;

            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch(FormatException formatException)
            {
                Console.WriteLine("the input is not correct format");
            }
            catch (OverflowException overFlowException)
            {
                Console.WriteLine("Value is too large or too small, take a look at datatype.");
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            switch (option)
            {
                case 1:
                    double sideLength = random.Next(1, 10);
                    double area = (Math.Pow(sideLength,2) * Math.Sqrt(3) / 4);
                    double roundedArea = Math.Round(area);
                    double userArea;
                    do
                    {
                        Console.WriteLine($"Side Length {sideLength}");
                        Console.WriteLine($"Calculate the area: ");
                        userArea = double.Parse(Console.ReadLine());
                        if(roundedArea == userArea)
                            Console.WriteLine("Bingo you are awesome");
                        else
                            Console.WriteLine("wrong, you can do it again");
                    }while (roundedArea != userArea);
                    break;

                    case 2:
                    Console.WriteLine(" we should validate triangle");
                    Console.WriteLine(" Becasue we use Heron's formula to calculate the area");

                key1: Console.WriteLine("First side: ");
                    double side1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Second side: ");
                    double side2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Third side");
                    double side3 = double.Parse(Console.ReadLine());

                    if((side1 + side2 > side3) && (side1 + side3 > side2) && (side3 + side2 > side1))
                    {
                        Console.WriteLine("Successfully validated !!!");
                        double semiPerimetr = (side1 + side2 + side3) / 2;
                        double areaTriangle = Math.Sqrt(semiPerimetr * (semiPerimetr - side1)
                                                * (semiPerimetr - side2)
                                                * (semiPerimetr - side3));
                        Console.WriteLine($"Area: {areaTriangle}");
                    }
                    else
                    {
                        Console.WriteLine("No such triangle exists. Enter right number");
                        goto key1;
                    }
                    break;

                default:
                    Console.WriteLine(" we have only two shapes, try again. ");
                    break;

            }


        }
    }
}
