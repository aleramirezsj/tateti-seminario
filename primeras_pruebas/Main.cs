using System;

namespace primeras_pruebas
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Cliente cliente1 = new Cliente(); 
			while (true) {
				//limpiamos la consola cada vez que se
				//ejecuta el while
				Console.Clear();
				Console.WriteLine("******Aplicación de Prueba******");
				Console.WriteLine("1-Cargar cliente");
				Console.WriteLine("2-Hacerlo hablar");
				Console.WriteLine("3-Salir");
				Console.Write("Ingrese una opción:");
				int opcion = Convert.ToInt32(Console.ReadLine());
				switch (opcion)
				{
					case 1:
						cliente1.CapturarDatos();
						break;
					case 2:
						cliente1.Hablar();
						Console.ReadLine();
						break;
					case 3:
						return;
				 	default:
						Console.WriteLine("Error en la opción ingresada");
						Console.ReadLine();
						break;
				}


			}





			/*Cliente cliente1 = new Cliente(); 
			cliente1.CapturarDatos();
	        cliente1.Hablar(); 
	        Console.ReadKey();*/ 
		}
	}
}
