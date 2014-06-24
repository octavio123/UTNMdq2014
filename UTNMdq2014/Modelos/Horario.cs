using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Modelos
{
    public class Horario
    {
        #region Propiedades automaticas

        public string Dia { get; set;} //Lunes, Martes, Miercoles, Jueves, Viernes o Sabado
        public DateTime HoraInicio { get; set;} //para determinar el rango horario
        public DateTime HoraFinal { get; set; } //para determinar el rango horario
        public string Aula { get; set; } //se usa para saber el numero de aula
        
        #endregion

        #region Constructores

        public Horario()
        {
            Dia = "";
            HoraInicio = new DateTime();
            HoraFinal = new DateTime();
            Aula = "";
        }

        public Horario(string dia, DateTime inicio, DateTime final, string aula)
        {
            Dia = dia;
            HoraInicio = inicio;
            HoraFinal = final;
            Aula = aula;
        }

        #endregion

        /// <summary>Devuelve un booleano true en el caso que haya superposicion, false en caso contrario
        /// la primera parte de la condicion verifica si el otro horario tiene una hora de inicio mayor o igual y dicha hora sea menor a la de fin
        /// la segunda parte verifica si el otro horario tiene una hora de fin mayor a la de inicio y dicha hora sea menor o igual a la de fin
        /// </summary>
        public bool Superposicion(Horario otro)
        {
            return ((otro.HoraInicio.CompareTo(HoraInicio) >= 0 && otro.HoraInicio.CompareTo(HoraFinal) == -1) || (otro.HoraFinal.CompareTo(HoraInicio) == 1 && otro.HoraFinal.CompareTo(HoraFinal) <= 0));
        }

        /// <summary> Compara el horario que se esta intentando cargar en este momento con todos los horarios existentes (y sus miembros)
        /// para determinar si se superponen en tiempo (dia), espacio (aula) y rango horario (horainicial-horafinal)
        /// si devuelve true, el Horario se superpone. No es el caso si devuelve false
        /// <summary>
        public bool Comprobacion(List<Curso> cursos, Horario actual)
        {
            foreach (var curso in cursos)
            {
                foreach (var horario in curso.Horarios)
                {
                    // Si el dia y el aula de los horarios son iguales y se superponen con sus rangos horarios
                    //entonces los horarios se superponen
                    if (horario.Superposicion(actual) && horario.Dia == actual.Dia && horario.Aula == actual.Aula)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
