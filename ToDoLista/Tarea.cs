using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoLista
{
    public class Tarea
    {
        //Encapsulando los atributos de las Tareas como String
        public string Nombre { get; set; } //Nombre de la Tarea
        public string Descripcion { get; set; } //Descripcion de la Tarea
        public string Horario { get; set; } //Horario a realizar la Tarea
        public string Fecha { get; set; } //Fecha a realizare la Tarea
        public string Estatus { get; set; } //Estatus de la Tarea

        public int NumeroTarea { get; set; } //Numero de la Tarea (en int para irle sumando con el Contador)

    }
}
