using System;
					
public class Program
{
	public static void Main()
	{
		int x, y, z;

            Console.WriteLine("Unesite vrijednost stranice x:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite vrijednost stranice y:");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite vrijednost stranice z:");
            z = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0 && z > 0)
            {
                if (x + y > z && x + z > y && y + z > x)
                {
                    Console.WriteLine("Unesene vrijednosti predstavljaju stranice pravokutnog trokuta.");
                }
                else
                {
                    Console.WriteLine("Stranice cine pravokutni trokut.");
                }
            }
            else
            {
                Console.WriteLine("Unesene vrijednosti moraju biti veće od 0.");
            }
	}
}