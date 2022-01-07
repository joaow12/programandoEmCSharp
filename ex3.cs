using System; 

class DIO {

    static void Main(string[] args) { 

      double c, S= 0;
            for (c = 1; c<=100; c++)
            {
                S += (1/c);
            }
            var x=Math.Round(S,2);
            Console.WriteLine(x);

    }

}