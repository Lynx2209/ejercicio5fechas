using Microsoft.VisualBasic;

namespace ejercicio5fechas
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Digame la primera fecha (dd/mm/yyyy hh:mm:ss) : ");
            String fechaDosStr = Console.ReadLine();
            Console.WriteLine("Digame la primera fecha (dd/mm/yyyy) : ");
            String fechaUnoStr = Console.ReadLine();

            DateTime fechaUno = DateTime.Parse(fechaUnoStr);
            DateTime fechaDos = DateTime.Parse(fechaDosStr);
            TimeSpan diferencia = fechaUno - fechaDos;
            Console.WriteLine(diferencia);

        }
    }
}