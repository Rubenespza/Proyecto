using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //cajero automatico//

            Console.SetBufferSize(10,25);

            int monto, cinco, diez, veinte, cincuenta, cien;
            string nombre;
            //Console.SetCursorPosition(5, 5);
            Console.Write("Ingrese Nombre.......");
            nombre = Console.ReadLine();

            Console.SetCursorPosition(5, 7);
            Console.Write("Ingrese Monto.....");
            monto = int.Parse(Console.ReadLine());
            if (monto % 5 == 0)
            {
                cien = monto / 100;
                monto = monto % 100;
                cincuenta = monto / 50;
                monto = monto % 50;
                veinte = monto / 20;
                monto = monto % 20;
                diez = monto / 10;
                monto = monto % 10;
                cinco = monto / 5;
                monto = monto % 5;
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("El monto en billetes de cien es ...." + cien);
                Console.SetCursorPosition(30, 12);
                Console.WriteLine("El monto en billetes de cincuenta es...." + cincuenta);
                Console.SetCursorPosition(30, 14);
                Console.WriteLine("El monto en billetes de veinte es...." + veinte);
                Console.SetCursorPosition(30, 16);
                Console.WriteLine("El monto en billetes de diez es....." + diez);
                Console.SetCursorPosition(30, 18);
                Console.WriteLine("El monto en billetes de cinco....." + cinco);
            }
            else
            {
                Console.SetCursorPosition(25, 20);
                Console.Write("MONTO NO VALIDO");

            }
            Console.ReadKey();

            }
        }
    }

