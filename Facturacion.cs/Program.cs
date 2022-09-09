using System;

namespace Facturacion.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int impuesto = 21, venta, porcentaje;
            Console.Write("Ingrese valor del producto: ");
            int producto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese porcentaje de utilidad: ");
            int utilidad = Convert.ToInt32(Console.ReadLine());

            venta = producto * utilidad * impuesto;
            impuesto = producto * impuesto;
            porcentaje = producto * utilidad;


            Console.WriteLine("Precio de venta: " + venta);
            Console.WriteLine("Precio + impuesto: " + impuesto);
            Console.WriteLine("Porcentaje de utilidad " + porcentaje);

            Console.ReadKey();
        }
    }
}
