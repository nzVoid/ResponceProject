using Calculation;
class Programm
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculation area");
        Console.WriteLine("Choose a figure:");
        Console.WriteLine("1)Circle");
        Console.WriteLine("2)Triangle");
        Console.Write("Enter number of figure: ");
        int point = Convert.ToInt32(Console.ReadLine());
        switch (point)
        {
            case 1:
                Console.Clear();
                Console.Write("Enter radius of circle: ");
                double rad = Convert.ToDouble(Console.ReadLine());
                if (rad > 0)
                {
                    var answer = AreaCalculation.circle(rad);
                    Console.WriteLine(answer);
                }
                else
                {
                    Console.WriteLine("Radius can't be less than zero");
                }
                
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Enter side a,b,c");
                Console.Write("Enter a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter c: ");
                double c = Convert.ToDouble(Console.ReadLine());
                if (a>0 && b>0 && c>0)
                {
                    if (AreaCalculation.rightTriangle(a, b, c) == true)
                    {
                        Console.WriteLine("Triangle is rectangular");
                    }
                    else
                    {
                        Console.WriteLine("Triangle is not rectangular ");
                    }
                    double answ = AreaCalculation.triangle(a, b, c);
                    Console.WriteLine(Convert.ToString(answ));
                }
                else
                {
                    Console.WriteLine("Sides can't be less than zero");
                }
                
                break;
        }
    }
}
