using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_htlm
{
    internal class Program
    {
        
        static void Main(string[] args)

        {
            do
            {

                Console.WriteLine("1.SUMAR");
                Console.WriteLine("2.RESTAR");
                Console.WriteLine("3.DIVIDIR");
                Console.WriteLine("4.POTENCIA");
                Console.WriteLine("5.AREA DEL TRIANGULO");
                Console.WriteLine("6.AREA DEL CUADRADO");
                Console.WriteLine("7.SALIR");
                Console.WriteLine(" favor escriba la opcion que desea ejecutar");
                string opcion = Console.ReadLine();
                opcion = opcion.ToUpper();

                int NUM1 = 0, NUM2 = 0;

                switch (opcion)

                {
                    case "SUMAR":

                        Console.WriteLine(" FAVOR DIGITE UN NUMERO EL CUAL DESEA SUMAR");
                        NUM1 = int.Parse(Console.ReadLine());
                        Console.WriteLine(" FAVOR DIGITE UN NUMERO EL CUAL DESEA SUMAR");
                        NUM2 = int.Parse(Console.ReadLine());
                        int suma = NUM1 + NUM2;
                        Console.WriteLine(" EL RESULTADO DE LA SUMA ES" + suma);
                        Console.WriteLine("SI DESEA REALIZAR OTRA SUMA DIGITE 1 PARA CONTINUAR O 2 PARA SALIR ");
                        int respuesta = int.Parse(Console.ReadLine());
                        if (respuesta == 1)

                        {
                            Console.WriteLine(" FAVOR DIGITE UN NUMERO EL CUAL DESEA SUMAR");
                            NUM1 = int.Parse(Console.ReadLine());
                            Console.WriteLine(" FAVOR DIGITE UN NUMERO EL CUAL DESEA SUMAR");
                            NUM2 = int.Parse(Console.ReadLine());

                        }
                        else
                        {
                            Console.WriteLine("SALIENDO...");
                        }
                        break;
                    case "RESTAR":

                        Console.WriteLine(" FAVOR DIGITE UN NUMERO EL CUAL DESEA RESTAR");
                        NUM1 = int.Parse(Console.ReadLine());
                        Console.WriteLine(" FAVOR DIGITE UN NUMERO EL CUAL DESEA RESTAR");
                        NUM2 = int.Parse(Console.ReadLine());
                        int restar = NUM1 - NUM2;
                        Console.WriteLine(" EL RESULTADO DE LA SUMA ES" + restar);
                        Console.WriteLine("SI DESEA REALIZAR OTRA RESTA DIGITE 1 PARA CONTINUAR O 2 PARA SALIR ");
                        respuesta = int.Parse(Console.ReadLine());
                        if (respuesta == 1)

                        {
                            Console.WriteLine(" FAVOR DIGITE UN NUMERO EL CUAL DESEA RESTAR");
                            NUM1 = int.Parse(Console.ReadLine());
                            Console.WriteLine(" FAVOR DIGITE UN NUMERO EL CUAL DESEA RESTAR");
                            NUM2 = int.Parse(Console.ReadLine());

                        }
                        else
                        {
                            Console.WriteLine("SALIENDO...");
                        }
                        break;
                    case "DIVIDIR":

                        Console.WriteLine(" FAVOR DIGITE UN NUMERO EL CUAL DESEA DIVIDIR");
                        NUM1 = int.Parse(Console.ReadLine());
                        Console.WriteLine(" FAVOR DIGITE UN NUMERO EL CUAL DESEA DIVIDIR");
                        NUM2 = int.Parse(Console.ReadLine());
                        int dividir = NUM1 / NUM2;
                        Console.WriteLine(" EL RESULTADO DE LA SUMA ES" + dividir);
                        Console.WriteLine("SI DESEA REALIZAR OTRA DIVISION DIGITE 1 PARA CONTINUAR O 2 PARA SALIR ");
                        respuesta = int.Parse(Console.ReadLine());
                        if (respuesta == 1)

                        {
                            Console.WriteLine(" FAVOR DIGITE UN NUMERO EL CUAL DESEA DIVIDIR");
                            NUM1 = int.Parse(Console.ReadLine());
                            Console.WriteLine(" FAVOR DIGITE UN NUMERO EL CUAL DESEA DIVIDIR");
                            NUM2 = int.Parse(Console.ReadLine());

                        }
                        else
                        {
                            Console.WriteLine("SALIENDO...");
                        }
                        break;
                    case "POTENCIA":

                        Console.WriteLine(" FAVOR DIGITE UN NUMERO EL CUAL DESEA POTENCIAR EL NUMERO 5");
                        double exponente = double.Parse(Console.ReadLine());
                        double numerobase = 5;
                        double resultado = Math.Pow(numerobase, exponente);


                        Console.WriteLine($"{numerobase} elevado a {exponente} es {resultado} ");
                        Console.WriteLine("SI DESEA REALIZAR OTRO CALCULO DIGITE 1 PARA CONTINUAR O 2 PARA SALIR ");
                        respuesta = int.Parse(Console.ReadLine());
                        if (respuesta == 1)

                        {
                            Console.WriteLine(" FAVOR DIGITE UN NUMERO EL CUAL DESEA ELEVAR");
                            exponente = int.Parse(Console.ReadLine());
                            Console.WriteLine($"{numerobase} elevado a {exponente} es {resultado} ");


                        }
                        else
                        {
                            Console.WriteLine("SALIENDO...");
                        }
                        break;
                    case "AREA DEL TRIANGULO":

                        Console.WriteLine(" FAVOR DIGITE EL LA BASE DEL TRIANGULO");
                        double baseTriangulo = double.Parse(Console.ReadLine());
                        Console.WriteLine(" FAVOR DIGITE EL LA ALTURA DEL TRIANGULO");
                        double alturaTriangulo = double.Parse(Console.ReadLine());
                        double area = 0.5 * baseTriangulo * alturaTriangulo;


                        Console.WriteLine($"El área del triángulo con base {baseTriangulo} y altura {alturaTriangulo} es {area}");
                        Console.WriteLine("SI DESEA REALIZAR OTRO CALCULO DIGITE 1 PARA CONTINUAR O 2 PARA SALIR ");
                        respuesta = int.Parse(Console.ReadLine());
                        if (respuesta == 1)

                        {
                            Console.WriteLine(" FAVOR DIGITE LA BASE DEL TRIANGULO");
                            baseTriangulo = double.Parse(Console.ReadLine());
                            Console.WriteLine(" FAVOR DIGITE EL LA ALTURA DEL TRIANGULO");
                            alturaTriangulo = double.Parse(Console.ReadLine());
                            area = 0.5 * baseTriangulo * alturaTriangulo;


                            Console.WriteLine($"El área del triángulo con base {baseTriangulo} y altura {alturaTriangulo} es {area}");
                            Console.WriteLine("SI DESEA REALIZAR OTRO CALCULO DIGITE 1 PARA CONTINUAR O 2 PARA SALIR ");


                        }
                        else
                        {
                            Console.WriteLine("SALIENDO...");
                        }
                        break;
                    case "AREA DEL CUADRADO":

                        Console.WriteLine(" FAVOR DIGITE EL VALOR DEL LADO DEL CUADRADO");
                        double lado = double.Parse(Console.ReadLine());

                        area = lado * lado;


                        Console.WriteLine($"El área del cuadrado con el lado {lado} es {area}");
                        Console.WriteLine("SI DESEA REALIZAR OTRO CALCULO DIGITE 1 PARA CONTINUAR O 2 PARA SALIR ");
                        respuesta = int.Parse(Console.ReadLine());
                        if (respuesta == 1)

                        {
                            Console.WriteLine(" FAVOR DIGITE EL VALOR DEL LADO DEL CUADRADO");
                            double lado = double.Parse(Console.ReadLine());

                            area = lado * lado;


                            Console.WriteLine($"El área del cuadrado con el lado {lado} es {area}");
                            Console.WriteLine("SI DESEA REALIZAR OTRO CALCULO DIGITE 1 PARA CONTINUAR O 2 PARA SALIR ");
                            respuesta = int.Parse(Console.ReadLine());


                        }
                        else
                        {
                            Console.WriteLine("SALIENDO...");
                        }
                        break;

                    case "SALIR":
                        break; 


                    default:
                        Console.WriteLine("INGRESE UNA OPCION CORRECTA");
                        break;
                }

            } while (opcion != "salir");
            Console.WriteLine("saliendo del menu");
          

            }
    }
}
