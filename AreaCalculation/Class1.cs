namespace Calculation
{
    public class AreaCalculation
    {
        public static double circle(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);
            return area;
        }
        public static double triangle(double a, double b ,double c)
        {
            double p = (a + b + c)/2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        public static bool rightTriangle(double a, double b, double c)
        {
            bool response = false;
            double hypot;
            if (a > b)
            {
                hypot = a;
                
            }
            else if (a>c)
            {
                hypot = a;
            }
            else if(b>c){
                hypot = b;
            }
            else
            {
                hypot = c;
            }
            if(hypot == a)
            {
                if(Math.Pow(hypot, 2) == Math.Pow(b, 2) + Math.Pow(c, 2)) { response = true; }
            }else if(hypot == b) {
                if(Math.Pow(hypot, 2) == Math.Pow(a, 2) + Math.Pow(c, 2)) { response = true; }
            }else if(hypot == c)
            {
                if(Math.Pow(hypot, 2) == Math.Pow(a, 2) + Math.Pow(b, 2)) { response = true; }
            }
            
            return response;
        }
    }
}