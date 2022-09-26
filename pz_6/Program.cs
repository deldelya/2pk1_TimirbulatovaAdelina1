namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //вариант 21
            //int chislo = 1, n = 7 , result ;
            //do
            //{
            //    result = n * chislo;
            //    Console.WriteLine("{0}*{1}={2}",n,chislo,result);
            //    chislo++;
            //} while (chislo <= 10); 
            Console.WriteLine("введите целое число");
            int i = Convert.ToInt32(Console.ReadLine());
            int j = 1;
            int k = 2;
            if (i % 2 == 0)
            { 
                //последний сомножитель 2
            }
            else
            { 
                //последний сомножитель 1
            }
           while( i >= 1 )
           {
                Console.WriteLine(j *= j - 2);
                j++;
            }
            Console.WriteLine(j);
        } 
    }
}

