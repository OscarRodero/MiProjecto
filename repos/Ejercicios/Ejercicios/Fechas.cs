using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios;

internal class Fechas
{
    public void Menu()
    {
        int opcion = 0;
        Console.WriteLine("¿Que apartado quieres hacer?");
        Console.WriteLine("1. Dia Semana");
        Console.WriteLine("2. Incrementar Fecha");
        Console.WriteLine("3. Diferencia Fecha");
        Console.WriteLine("4. Compara Fechas");
        Console.WriteLine("5. Mostrar fecha formato largo");
        try
        {
            opcion = int.Parse(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        switch (opcion)
        {
            case 1:
                DiaFecha();
                break;
            case 2:
                IncrementarFecha();
                break;
            case 3:
                DiferenciarFechas();
                break;
            case 4:
                CompararFechas();
                break;
            case 5:
                MFFL();
                break;
        }
    }
    public void DiaFecha()
    {
        Console.WriteLine("Dame una fecha y te digo el día de la semana.");
        string fecha = Console.ReadLine();
        DateTime fecha1 = DateTime.Parse(fecha);
        Console.WriteLine("El dia es : " + fecha1.DayOfWeek);
    }

    public void IncrementarFecha()
    {
        int dias = 0;
        Console.WriteLine("Dame una fecha");
        string fecha = Console.ReadLine();
        DateTime fecha1 = DateTime.Parse(fecha);
        do
        {
            Console.WriteLine("¿Cuantos días debería sumar a la fecha?");
            try
            {
                dias = int.Parse(Console.ReadLine());
                Console.WriteLine(fecha1.AddDays(dias));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
            }
        } while (dias <= 0);

    }

    public void DiferenciarFechas()
    {
        Console.WriteLine("Dame la primera fecha");
        string fecha1 = Console.ReadLine();
        Console.WriteLine("Dame la segunda fecha");
        string fecha2 = Console.ReadLine();
        DateTime f1 = DateTime.Parse(fecha1);
        DateTime f2 = DateTime.Parse(fecha2);
        if (f1 > f2)
        {
            Console.WriteLine(f1 - f2);
        }
        else if (f1 < f2)
        {
            Console.WriteLine(f2 - f1);
        }
        else
        {
            Console.WriteLine("Son la misma fecha");
        }
    }

    public void CompararFechas()
    {
        Console.WriteLine("Dame la primera fecha");
        string fecha1 = Console.ReadLine();
        Console.WriteLine("Dame la segunda fecha");
        string fecha2 = Console.ReadLine();
        DateTime f1 = DateTime.Parse(fecha1);
        DateTime f2 = DateTime.Parse(fecha2);
        if (f1 > f2)
        {
            Console.WriteLine("La primera fecha es mayor");
        }
        else if (f1 < f2)
        {
            Console.WriteLine("La segunda fecha es mayor");
        }
        else
        {
            Console.WriteLine("Son la misma fecha");
        }
    }

    public void MFFL()
    {
        Console.WriteLine("Dame una fecha");
        string fecha = Console.ReadLine();
        DateTime fecha1 = DateTime.Parse(fecha);
        Console.WriteLine(fecha1.ToLongDateString);
    }

}
