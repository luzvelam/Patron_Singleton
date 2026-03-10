using System;
using System.Collections.Generic;
using System.Text;


namespace PrototypeExamen
{
    public class InteligenciaArtificialExam : ExamenPrototype
    {
        public override ExamenPrototype Clone()
        {
            return (InteligenciaArtificialExam)this.MemberwiseClone();
        }

        public override string MostrarExamen()
        {
            return $"Materia: {_materia} | Docente: {_docente} | Estudiante: {_estudiante} | Salón: {_salon} | Preguntas: {_preguntas} | Rúbrica: {_rubrica}%";
        }

        public override string Modalidad()
        {
            return "Modalidad: Examen practico con ejercicios de IA";
        }

        public override string Revision()
        {
            return "Revision del examen";
        }

        public override double Promediar()
        {
            return _rubrica * 0.5;
        }
    }
}