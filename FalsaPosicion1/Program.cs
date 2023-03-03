using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using org.mariuszgromada.math.mxparser;

namespace FalsaPosicion1
{

	class Program
	{
		public static class Global
		{
			public static string? evalu;
		}
		static int max_iteracion = 2000;
		
		static void Main(string[] args)
		{


			//variables necesarias
					




			double xr = 0; //para la raiz
			double xa = 0; //para el anterior de la formula del error
			double error = 0; //para la formula del erros
			int iteracion = 0; //numero de iteraciones
		

			//ingresar la funcion

			//Console.WriteLine("Ingrese la Funcion");

			//Global.evalu = Console.ReadLine();
			
			

			//pedir el valor de Xi que es el inferior
			Console.WriteLine("Dame el valor de xi");
			double xi = Convert.ToDouble(Console.ReadLine());

			//pedir el valor de Xs que es el superior
			Console.WriteLine("Dame el valor de xs");
			double xs = Convert.ToDouble(Console.ReadLine());

			//falsa posicion 

			for (int i = 0; i <= max_iteracion; i++)
			{
				
				xa = xr;
				//(formula original)xr = xs - (((F(xs)) * (xi - xs)) / (F(xi) - F(xs)));
				// se simplifica la formula para hacerla mas facil 
				xr = (xi * F(xs) - xs * F(xi)) / (F(xs) - F(xi));

				if (F(xr) == 0)
				{
					break;
				}
				else if ((F(xr) * F(xi)) < 0)
				{
					xs = xr;
				}
				else
				{
					xi = xr;
				}

				error = (((xr - xa) / xr) * 100);

				if (Math.Abs(error) <= 0.0001)
				{
					break;
				}

				iteracion++;

				Console.WriteLine("Raiz = {0}", xr);
				Console.WriteLine("{0}  Raiz: {1}  Xl: {2}  Xu: {3}  Error: {4}", i, xr, xi, xs, Math.Abs(error));
			}

			Console.WriteLine("La catidad de iteraciones fue: {0}", iteracion);
			Console.WriteLine("x={0}", xr);

		}

		static double F(double e)
		{
            //Function f = new Function(Global.evalu);
            //(e-1)* (e - 1)* (e - 1) "(-1,3)" => raiz= 1
            //Math.Sin(e)+Math.Cos(e) "(-8,-5)" => raiz= -7.068583470576942
            //((Math.Pow((Math.Sqrt(e-5)/2),3))-3) "(0,17)" => NaN
            //((Math.Pow((Math.Sqrt(e-5)/2),3))-3) "(6,17)" => raiz = 13.32033451168127

            double operacion = ((((Math.Pow((e-5),(1/3))))/8)-3);
			
			return operacion;
		}



	}
}




