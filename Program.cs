using System;

namespace CompositeComputadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1. Computadora de gama alto");
                Console.WriteLine("2. Computadora de gama Medio");
                Console.WriteLine("3. Computadora de gama Bajo");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione: ");

                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        ArmarPC("Computadora Cliente de gama alto", "Alta");
                        break;
                    case 2:
                        ArmarPC("Computadora Cliente de gama media", "Media");
                        break;
                    case 3:
                        ArmarPC("Computadora Cliente bajo", "Económica");
                        break;
                }

            } while (opcion != 4);
        }

        static void ArmarPC(string nombre, string tipo)
        {
            Directorio pc = new Directorio(nombre, tipo);
            Directorio gabinete = new Directorio("Gabinete");

            
            int precioCPU1, precioCPU2;
            int precioRAM1, precioRAM2;
            int precioDISCO1, precioDISCO2;
            int precioTEC1, precioTEC2;
            int precioMOU1, precioMOU2;

           
            if (tipo == "Alta") 
                {
                    precioCPU1 = 8000; precioCPU2 = 6000;
                    precioRAM1 = 5000; precioRAM2 = 3000;
                    precioDISCO1 = 4000; precioDISCO2 = 2000;
                    precioTEC1 = 1500; precioTEC2 = 800;
                    precioMOU1 = 1200; precioMOU2 = 600;
                }
            else if (tipo == "Media") 
            {
                precioCPU1 = 3000; precioCPU2 = 2800;
                precioRAM1 = 1500; precioRAM2 = 800;
                precioDISCO1 = 2000; precioDISCO2 = 700;
                precioTEC1 = 800; precioTEC2 = 500;
                precioMOU1 = 600; precioMOU2 = 300;
            }
            else // ECONOMICO
            {
                precioCPU1 = 2000; precioCPU2 = 1500;
                precioRAM1 = 800; precioRAM2 = 500;
                precioDISCO1 = 700; precioDISCO2 = 400;
                precioTEC1 = 400; precioTEC2 = 250;
                precioMOU1 = 300; precioMOU2 = 150;
            }

            Console.Clear();
            Console.WriteLine($"Armando {nombre}\n");

            
            Console.WriteLine("CPU:");
            Console.WriteLine($"1. Intel i5 (${precioCPU1})");
            Console.WriteLine($"2. Ryzen 5 (${precioCPU2})");
            int cpu = int.Parse(Console.ReadLine());

            if (cpu == 1)
                gabinete.AgregarHijo(new Archivo("Intel i5", precioCPU1));
            else
                gabinete.AgregarHijo(new Archivo("Ryzen 5", precioCPU2));

            
            Console.WriteLine("\nRAM:");
            Console.WriteLine($"1. 16GB (${precioRAM1})");
            Console.WriteLine($"2. 8GB (${precioRAM2})");
            int ram = int.Parse(Console.ReadLine());

            if (ram == 1)
                gabinete.AgregarHijo(new Archivo("RAM 16GB", precioRAM1));
            else
                gabinete.AgregarHijo(new Archivo("RAM 8GB", precioRAM2));


            Console.WriteLine("\nAlmacenamiento:");
            Console.WriteLine($"1. SSD 1TB (${precioDISCO1})");
            Console.WriteLine($"2. HDD 500GB (${precioDISCO2})");
            int disco = int.Parse(Console.ReadLine());

            if (disco == 1)
                gabinete.AgregarHijo(new Archivo("SSD 1TB", precioDISCO1));
            else
                gabinete.AgregarHijo(new Archivo("HDD 500GB", precioDISCO2));

        
            Console.WriteLine("\nTeclado:");
            Console.WriteLine($"1. Logitech (${precioTEC1})");
            Console.WriteLine($"2. Redragon (${precioTEC2})");
            int teclado = int.Parse(Console.ReadLine());

            if (teclado == 1)
                gabinete.AgregarHijo(new Archivo("Teclado Logitech", precioTEC1));
            else
                gabinete.AgregarHijo(new Archivo("Teclado Redragon", precioTEC2));


            Console.WriteLine("\nMouse:");
            Console.WriteLine($"1. Logitech (${precioMOU1})");
            Console.WriteLine($"2. Genius (${precioMOU2})");
            int mouse = int.Parse(Console.ReadLine());

            if (mouse == 1)
                gabinete.AgregarHijo(new Archivo("Mouse Logitech", precioMOU1));
            else
                gabinete.AgregarHijo(new Archivo("Mouse Genius", precioMOU2));

            pc.AgregarHijo(gabinete);

    
            Console.Clear();
            Console.WriteLine("===== RESULTADO =====");
            Console.WriteLine($"Tipo: {tipo}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine("\nDescripción:");
            Console.WriteLine(pc.ObtenerDescripcion());
            Console.WriteLine($"Costo total: ${pc.ObtenerCosto()}");
            Console.ReadLine();
        }
    }
}