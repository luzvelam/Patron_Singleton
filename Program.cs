using singleton;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        Central_911 Llamada1 = Central_911.Obtener_Instancia();
        Central_911 Llamada2 = Central_911.Obtener_Instancia();

        Operador op1 = new Operador(1, "Laura");
        Operador op2 = new Operador(2, "Carlos");
        Operador op3 = new Operador(3, "Lucero");
        Operador op4 = new Operador(4, "sofia");
        Operador op5 = new Operador(5, "Santiago");
        Operador op6 = new Operador(6, "Jesus");
        Operador op7 = new Operador(7, "Lizari");
        Operador op8 = new Operador(8, "Deyver");
        Operador op9 = new Operador(9, "katy");
        Operador op10 = new Operador(10, "Valentina");


        Llamada1.ConectarLlamada(op1, "Incendio");
        Llamada2.ConectarLlamada(op2, "Violeta");
        Llamada1.ConectarLlamada(op3, "Accidente");
        Llamada2.ConectarLlamada(op4, "Intento de suicidio");
        Llamada1.ConectarLlamada(op5, "Incendio");
        Llamada2.ConectarLlamada(op6, "Accidente");
        Llamada1.ConectarLlamada(op7, "Violeta");
        Llamada2.ConectarLlamada(op8, "Incendio");
        Llamada1.ConectarLlamada(op9, "Intento de suicidio");
        Llamada2.ConectarLlamada(op10, "Accidente");

        Console.WriteLine("\n¿Es la misma instancia?");
        Console.WriteLine(ReferenceEquals(Llamada1, Llamada2));

        Console.ReadKey();
    }
}