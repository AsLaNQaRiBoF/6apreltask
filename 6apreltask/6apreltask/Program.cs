namespace _6apreltask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 - Square üçün");
            Console.WriteLine("1 - Rectangular  üçün");
            Console.WriteLine("2 - Quit üçün");
            Console.Write("Seciminizi edin: ");
            {
                int choose = int.Parse(Console.ReadLine());
                while (true)
                {
                    switch (choose)
                    {
                        case 0:
                            Square.CalcArea();
                            break;
                        case 1:

                            Rectangular.CalcArea();
                            break;
                        case 2:
                            Console.WriteLine("Quit"); 
                            break;
                    }

                }
            }
        }
    }
}