using System;

namespace PrototypeExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prototipos de examenes
            PatronesDisenoExam prototipoPD = new PatronesDisenoExam();
            InteligenciaArtificialExam prototipoIA = new InteligenciaArtificialExam();
            TallerSistemasOperativosExam prototipoSO = new TallerSistemasOperativosExam();
            AdministracionRedesExam prototipoRedes = new AdministracionRedesExam();
            ProgramacionWebExam prototipoWeb = new ProgramacionWebExam();
            DesarrolloSustentableExam prototipoDS = new DesarrolloSustentableExam();
            LenguajesAutomatasExam prototipoLA = new LenguajesAutomatasExam();
            TallerInvestigacionExam prototipoTI = new TallerInvestigacionExam();

            // Patrones de Diseño
            ExamenPrototype examen1 = prototipoPD.Clone();
            examen1.Materia = "Patrones de Diseño";
            examen1.Docente = "Maribel guerrero";
            examen1.Grupo = "A";
            examen1.Salon = "Lab 91L5";
            examen1.Estudiante = "Lucero velazquez";
            examen1.Preguntas = 10;
            examen1.Rubrica = 50;

            Console.WriteLine(examen1.MostrarExamen());
            Console.WriteLine(examen1.Modalidad());
            Console.WriteLine(examen1.Revision());
            Console.WriteLine("Promedio: " + examen1.Promediar());
            Console.WriteLine("--------------------------------");


            // Inteligencia Artificial
            ExamenPrototype examen2 = prototipoIA.Clone();

            examen2.Materia = "Inteligencia Artificial";
            examen2.Docente = "alaniz";
            examen2.Grupo = "A";
            examen2.Salon = "Lab 91L6";
            examen2.Estudiante = "katy";
            examen2.Preguntas = 10;
            examen2.Rubrica = 50;

            Console.WriteLine(examen2.MostrarExamen());
            Console.WriteLine(examen2.Modalidad());
            Console.WriteLine(examen2.Revision());
            Console.WriteLine("Promedio: " + examen2.Promediar());
            Console.WriteLine("--------------------------------");


            // Taller de Sistemas Operativos
            ExamenPrototype examen3 = prototipoSO.Clone();
            examen3.Materia = "Taller de Sistemas Operativos";
            examen3.Docente = "jorgue octavio flores";
            examen3.Grupo = "A";
            examen3.Salon = "Sala 9301";
            examen3.Estudiante = "deyver";
            examen3.Preguntas = 12;
            examen3.Rubrica = 50;

            Console.WriteLine(examen3.MostrarExamen());
            Console.WriteLine(examen3.Modalidad());
            Console.WriteLine(examen3.Revision());
            Console.WriteLine("Promedio: " + examen3.Promediar());
            Console.WriteLine("--------------------------------");


            // Administración de Redes
            ExamenPrototype examen4 = prototipoRedes.Clone();
            examen4.Materia = "Administración de Redes";
            examen4.Docente = "jesus palma";
            examen4.Grupo = "A";
            examen4.Salon = "Lab Redes";
            examen4.Estudiante = "Luisa";
            examen4.Preguntas = 15;
            examen4.Rubrica = 50;

            Console.WriteLine(examen4.MostrarExamen());
            Console.WriteLine(examen4.Modalidad());
            Console.WriteLine(examen4.Revision());
            Console.WriteLine("Promedio: " + examen4.Promediar());
            Console.WriteLine("--------------------------------");

            // Programación Web
            ExamenPrototype examen5 = prototipoWeb.Clone();
            examen5.Materia = "Programación Web";
            examen5.Docente = "parra ";
            examen5.Grupo = "A";
            examen5.Salon = "Lab Web";
            examen5.Estudiante = "lizari";
            examen5.Preguntas = 20;
            examen5.Rubrica = 70;

            Console.WriteLine(examen5.MostrarExamen());
            Console.WriteLine(examen5.Modalidad());
            Console.WriteLine(examen5.Revision());
            Console.WriteLine("Promedio: " + examen5.Promediar());
            Console.WriteLine("--------------------------------");

            // Desarrollo Sustentable
            ExamenPrototype examen6 = prototipoDS.Clone();
            examen6.Materia = "Desarrollo Sustentable";
            examen6.Docente = "Lucerito";
            examen6.Grupo = "B";
            examen6.Salon = "Aula 914";
            examen6.Estudiante = "lizari";
            examen6.Preguntas = 8;
            examen6.Rubrica = 50;

            Console.WriteLine(examen6.MostrarExamen());
            Console.WriteLine(examen6.Modalidad());
            Console.WriteLine(examen6.Revision());
            Console.WriteLine("Promedio: " + examen6.Promediar());
            Console.WriteLine("--------------------------------");


            // Lenguajes y Autómatas
            ExamenPrototype examen7 = prototipoLA.Clone();
            examen7.Materia = "Lenguajes y Autómatas I";
            examen7.Docente = "luis Gaxiola";
            examen7.Grupo = "A";
            examen7.Salon = "Sala 301";
            examen7.Estudiante = "jesus";
            examen7.Preguntas = 12;
            examen7.Rubrica = 50;

            Console.WriteLine(examen7.MostrarExamen());
            Console.WriteLine(examen7.Modalidad());
            Console.WriteLine(examen7.Revision());
            Console.WriteLine("Promedio: " + examen7.Promediar());
            Console.WriteLine("--------------------------------");


            // Taller de Investigación
            ExamenPrototype examen8 = prototipoTI.Clone();
            examen8.Materia = "Taller de Investigación I";
            examen8.Docente = "Gabriela Tapia";
            examen8.Grupo = "C";
            examen8.Salon = "Aula 9301";
            examen8.Estudiante = "Lucero";
            examen8.Preguntas = 6;
            examen8.Rubrica = 50;

            Console.WriteLine(examen8.MostrarExamen());
            Console.WriteLine(examen8.Modalidad());
            Console.WriteLine(examen8.Revision());
            Console.WriteLine("Promedio: " + examen8.Promediar());
            Console.WriteLine("--------------------------------");


            Console.ReadKey();
        }
    }
}