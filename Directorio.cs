using CompositeComputadora;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Directorio : Componente
{
    private List<Componente> hijos = new List<Componente>();

    public Directorio(string nombre) : base(nombre) { }

    public Directorio(string nombre, string tipo) : base(nombre + " (" + tipo + ")") { }

    public override void AgregarHijo(Componente c)
    {
        hijos.Add(c);
    }

    public override int ObtenerCosto()
    {
        int total = 0;
        foreach (var hijo in hijos)
        {
            total += hijo.ObtenerCosto();
        }
        return total;
    }

    public override string ObtenerDescripcion()
    {
        string resultado = nombre + "\n";
        foreach (var hijo in hijos)
        {
            resultado += "  " + hijo.ObtenerDescripcion() + "\n";
        }
        return resultado;
    }
}