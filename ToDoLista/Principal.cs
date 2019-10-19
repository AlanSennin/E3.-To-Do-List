using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoLista
{
    public class Principal
    {
        List<Tarea> ALista = new List<Tarea>(); //Creo la lista con los atributos de la clase "Tarea" en global

        int Contador = 1; //Contador global para asignar el numero de Tarea al imprimir
        internal void Bienvenida() //Metodo solo para la bienvenida del programa
        {
            Console.WriteLine("¡BIENVENIDO A TU CUADERNO DE TAREAS!");
            Console.WriteLine("");

            Menu(); //Mando a llamar al Menu principal del programa
        }
        public void Menu() //Metodo Menu para seleccionar la opcion que se necesite
        {
            Console.WriteLine("(1) Agregar una Tarea");
            Console.WriteLine("(2) Ver Lista de Tareas");
            Console.WriteLine("(3) Detalles de Tarea");
            Console.WriteLine("(4) Mostrar Estatus de Tarea");
            Console.WriteLine("(5) Cambiar Estatus de Tarea");
            Console.WriteLine("");
            Console.WriteLine("(6) Salir...");

            switch (Console.ReadLine()) //Switch para mandar llamar el metodo necesario
            {
                case "1":
                    Console.Clear(); //Limpiamos la consola...
                    AgregarTarea(); //Mando a llamar el metodo AgregarTarea()...
                    break;

                case "2":
                    Console.Clear(); //Limpiamos la consola...
                    VerListaTareas(); //Mando a llamar el metodo VerListaTareas()...
                    break;

                case "3":
                    Console.Clear(); //Limpiamos la consola...
                    DetallesTarea(); //Mando a llamar el metodo DetallesTarea()...
                    break;

                case "4":
                    Console.Clear(); //Limpiamos la consola...
                    ListaEstatus(); //Mando a llamar el metodo ListaEstatus()...
                    break;

                case "5":
                    Console.Clear(); //Limpiando la consola...
                    CambiarEstatus(); //Mando a llamar el metodo CambiarEstatus()...
                    break;

                case "6":
                    System.Environment.Exit(-1); //Codigo para cerrar el programa
                    break;

                default:
                    Console.WriteLine("Presiona enter e ingrese una opcion valida...");
                    Console.ReadKey();
                    Console.Clear(); //Limpiamos la consola...
                    Menu(); //Nos regresamos al Menu principal una vez presionado una tecla
                    break;
            }
        }

        public void AgregarTarea() //Metodo para ingresar los datos de las tareas a la lista
        {
            Console.WriteLine("--- CREAR TAREA ---");
            Console.WriteLine("");

            Console.WriteLine("Ingrese Nombre: ");
            string Nombre1 = Console.ReadLine(); //Creamos una variable en String y le damos un valor al Nombre
            Console.WriteLine("");

            Console.WriteLine("Ingrese Descripcion: ");
            string Descripcion1 = Console.ReadLine(); //Creamos una variable en String y le damos un valor a la Descripcion
            Console.WriteLine("");

            Console.WriteLine("Ingrese Horario: ");
            string Horario1 = Console.ReadLine(); //Creamos una variable en String y le damos una valor al Horario
            Console.WriteLine("");

            Console.WriteLine("Ingrese Fecha: ");
            string Fecha1 = Console.ReadLine(); //Creamos una variable en String y le damos un valor a la Fecha
            Console.WriteLine("");

            Console.WriteLine("Ingrese Estatus: (1) Listo (2) Pendiente (3) En Proceso...");
            string Estatus1 = Console.ReadLine(); //Le damos un valor al Estatus (Listo, Pendiente o En Proceso)
            Console.WriteLine("");

            //Condicional para decirle que vale cada numero a lo ingresado anteriormente 
            if (Estatus1 == "1") //Si Ingresamos 1...
            {
                Estatus1 = "Listo"; //Al ingresar "1" este significa que la tarea esta Lista
            }
            else
            {
                if (Estatus1 == "2") //Si Ingresamos 2...
                {
                    Estatus1 = "Pendiente"; //Al ingresar "2" este significa que la tarea esta Pendiente
                }
                else
                {
                    if (Estatus1 == "3") //Si Ingresamos 3...
                    {
                        Estatus1 = "En Proceso..."; //Al ingresar "3" este significa que la tarea esta En Proceso
                    }
                    else
                        Console.WriteLine("Ingrese un valor correcto."); //Aqui te la hace de pedo si no metes un valor del 1 al 3 xd
                }
            }

            //Aqui le asignamos a los valores que intruducimos a los atributos principales de la clase "Tarea"
            ALista.Add(new Tarea { Nombre = Nombre1, Descripcion = Descripcion1, Horario = Horario1, Fecha = Fecha1, Estatus = Estatus1 }); 

            Console.WriteLine("Presione cualquier tecla para regresar al menu...");
            Console.ReadKey();
            Console.Clear(); //Limpiamos la consola...
            Menu(); //Mandamos llamar el Menu...
        }

        public void VerListaTareas() //Metodo para ver que numero de Tarea es y su Nombre
        {
            Contador = 1; //Le vuelvo a asignar valor 1 al contador para que no siga acumulando mas valores 

            foreach (var item in ALista) //Foreach para imprimir los valores ingresados a la lista asi sean 1 o mas por atributo
            {
                item.NumeroTarea = Contador++; //Asiganrle al Numero de la Tarea el contador +1

                Console.WriteLine("Tarea Numero: " + item.NumeroTarea); //Imprimo el numero de tarea que es 
                Console.WriteLine("");
                Console.WriteLine("Nombre: " + item.Nombre); //Imprimo el nombre de la tarea

                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------");
            }

            Console.WriteLine("Presione cualquier tecla para regresar al menu...");
            Console.ReadKey();
            Console.Clear(); //Limpiamos la consola...

            Menu(); //Mandamos llamar el Menu...
        }

        public void DetallesTarea() //Metodo para ver los detalles de las tareas
        {
            Contador = 1; //Le vuelvo a asignar valor 1 al contador para que no siga acumulando mas valores 

            foreach (var item in ALista) //Foreach para imprimir los valores ingresados a la lista asi sean 1 o mas por atributo
            {
                item.NumeroTarea = Contador++; //Asiganrle al Numero de la Tarea el contador +1

                Console.WriteLine("Tarea Numero: " + item.NumeroTarea); //Imprimo el numero de la tarea que es
                Console.WriteLine("");
                Console.WriteLine("Nombre: " + item.Nombre); //Imprimo el nombre de la tarea que es
                Console.WriteLine("Descripcion: " + item.Descripcion); //Imprimo la descripcion de la tarea que es
                Console.WriteLine("Horario: " + item.Horario); //Imprimo el horario de la tarea que es
                Console.WriteLine("Fecha: " + item.Fecha); //Imprimo la fecha de la tarea que es
                Console.WriteLine("");
                Console.WriteLine("Estatus: " + item.Estatus); //Imprimo el estatus de la tarea que es

                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------");
            }

            Console.WriteLine("Presione cualquier tecla para regresar al menu...");
            Console.ReadKey();
            Console.Clear(); //Limpiamos la consola...

            Menu(); //Mandamos llamar el Menu...
        }

        public void ListaEstatus() //Metodo para ver la lista de los estatus de las tareas
        {
            Contador = 1; //Le vuelvo a asignar valor 1 al contador para que no siga acumulando mas valores 

            foreach (var item in ALista) //Foreach para imprimir los valores ingresados a la lista asi sean 1 o mas por atributo
            {
                item.NumeroTarea = Contador++; //Asiganrle al Numero de la Tarea el contador +1

                Console.WriteLine("Tarea Numero: " + item.NumeroTarea); //Imprimo el numero de la tarea que es
                Console.WriteLine("");
                Console.WriteLine("Estatus: " + item.Estatus); //Imprimo el estatus de la tarea que es

                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------");
            }

            Console.WriteLine("Presione cualquier tecla para regresar al menu...");
            Console.ReadKey();
            Console.Clear(); //Limpiamos la consola...

            Menu(); //Mandamos llamar el Menu...
        }

        public void CambiarEstatus() //Metodo para cambiar el estatus de la tarea
        {
            Console.WriteLine("Ingrese el numero de Tarea:");
            int Numero = int.Parse(Console.ReadLine()); //Ingresamos el numero de la tarea
            Console.WriteLine("");

            Tarea T = new Tarea(); //Instanciamos la clase Tarea como T

            foreach (var item in ALista) //foreach para ver el numero de tarea 
            {
                if (Numero == item.NumeroTarea) //Condicional para que Numero sea igual al atributo NumeroTarea
                {
                    T = item;
                }
            }

            Console.WriteLine("Ingresa el nuevo Estatus de la Tarea: (1) Lista (2) Pendiente (3) En Proceso...");
            T.Estatus = Console.ReadLine(); //Le ingresamos un nuevo estatus al estatus xddd
            Console.WriteLine("");

            if (T.Estatus == "1")
            {
                T.Estatus = "Lista"; //Si ingresamos "1" el estatus pasa a estar Listo
            }
            else
            {
                if (T.Estatus == "2")
                {
                    T.Estatus = "Pendiente"; //Si ingresamo "2" el estatus pasa a estar Pendiente
                }
                else
                {
                    if (T.Estatus == "3") 
                    {
                        T.Estatus = "En Proceso..."; //Si ingresamos "3" el estatus pasa a estar En Proceso...
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un valor correcto."); //Aqui te la hace de pedo x2 si no ingresas un valor entre 1 y 3 xdd
                    }
                }
            }

            Console.WriteLine("Presione cualquier tecla para regresar al menu...");
            Console.ReadKey();
            Console.Clear(); //Limpiamos la consola...

            Menu(); //Mandamos llamar el Menu...
        }
    }
}
