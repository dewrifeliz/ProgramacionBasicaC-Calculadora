using System;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;

class Program
{
    static double sumar(double numero1, double numero2)
    {
        return numero1 + numero2;
    }

    static double restar(double numero1, double numero2)
    {
        return numero1 - numero2;
    }

    static double dividir(double numero1, double numero2)
    {
        return numero1 / numero2;

    }

    static double multiplicar(double numero1, double numero2)
    {
        return numero1 * numero2;
    }

    static double Leermensaje(string mensaje)
    {
        Console.Write(mensaje);
        return
            Convert.ToDouble(Console.ReadLine());
    }

    static void Main()
    {
        Console.WriteLine("=======Calculadora=======");
        double numero1 = Leermensaje("Ingrese el primer numero: ");
        double numero2 = Leermensaje("Ingrese el segundo numero: ");

        Console.WriteLine("suma" + sumar(numero1, numero2));
        Console.WriteLine("Resta" + restar(numero1, numero2));
        Console.WriteLine("Multiplicacion" + multiplicar(numero1, numero2));

        if (numero2 != 0)
        {
            Console.WriteLine("Division" + dividir(numero1, numero2));
        }
        else
        {
            Console.WriteLine("division: Error al dividir");

        }
    }


}