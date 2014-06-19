using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Modelos
{
    public class Horario
    {
        //clase mutable
        //propiedades automaticas

        public string Dia {get; set;} //Lunes, Martes, Miercoles, Jueves, Viernes o Sabado
        public Hora HoraInicio {get; set;} //para determinar el rango horario
        public Hora HoraFinal { get; set; } //para determinar el rango horario
        public string Aula {get; set;} //se usa para saber el numero de aula

        //constructores

        public Horario()
        {
            Dia = "";
            HoraInicio = new Hora();
            HoraFinal = new Hora();
            Aula = "";
        }

        public Horario(string dia, Hora inicio, Hora final, string aula)
        {
            Dia = dia;
            HoraInicio = inicio;
            HoraFinal = final;
            Aula = aula;
        }

        //metodos

        //Devuelve un booleano true en el caso que haya superposicion, false en caso contrario
        //la primera parte de la condicion verifica si el otro horario tiene una hora de inicio mayor o igual y dicha hora sea menor a la de fin
        //la segunda parte verifica si el otro horario tiene una hora de fin mayor a la de inicio y dicha hora sea menor o igual a la de fin
        public bool Superposicion(Horario otro)
        {
            return ((otro.HoraInicio.Comparar(HoraInicio) >= 0 && otro.HoraInicio.Comparar(HoraFinal) == -1) || (otro.HoraFinal.Comparar(HoraInicio) == 1 && otro.HoraFinal.Comparar(HoraFinal) <= 0));
        }

        //compara el horario que se esta intentando cargar en este momento con todos los horarios existentes (y sus miembros)
        //para determinar si se superponen en tiempo (dia), espacio (aula) y rango horario (horainicial-horafinal)
        //si devuelve true, el Horario se superpone. No es el caso si devuelve false

        public bool Comprobacion(List<Curso> listacursos, Horario actual)
        {
            for (int i = 0; i < listacursos.Count; i++)
            {
                for (int u = 0; u < listacursos[i].ListaHorario.Count; u++)
                {
                    //si el dia y el aula de los horarios son iguales y se superponen con sus rangos horarios
                    //entonces los horarios se superponen
                    if (listacursos[i].ListaHorario[u].Superposicion(actual) && listacursos[i].ListaHorario[u].Dia==actual.Dia && listacursos[i].ListaHorario[u].Aula==actual.Aula)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
