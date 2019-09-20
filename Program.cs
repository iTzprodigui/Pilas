/*
Realizado por: Castillo Guzman Carlos Emilio 
Matricula: 61729
 */
using System;
using System.Collections;

namespace pilas{
    class Program{
        static void Main(string[] args){
            /*Hacemos declaracion de las variables pila como Stack y nElementos como tipo entero */
            Stack pila = new Stack();
            int nElementos;

            /*Declaramos un while que siempre sera verdadero para cuando se borre nuestro menu, este vuelva a
            aparecer en la consola */
            while (true){
                Console.WriteLine("1. Insertar elemento");
                Console.WriteLine("2. Ver pila");
                Console.WriteLine("3. Total de elementos");
                Console.WriteLine("4. ¿Contiene?");
                Console.WriteLine("5. Salir");
                Console.WriteLine("\n");
                Console.WriteLine("Digite una opccion:");

                /* Hacemos una captura de la exepccion FormatException en caso de que el usuario ingrese 
                otro valor que no sea de tipo entero */
                try{
                    int respuesta = Convert.ToInt32(Console.ReadLine());    
                    
                        /*Usamos un switch para desplegar un menu al usuario */
                        switch (respuesta){
                            /*Le aplicamos la opccion de casos y en cada uno hacemos una llamada de cada metodo que hemos
                            creado */
                            case 1:
                                Console.WriteLine("Cuantos elementos desea ingresar en la pila?");
                                nElementos = Convert.ToInt32(Console.ReadLine());
                                insertarPila(pila,nElementos);
                            break;
                            case 2:
                                verPila(pila);
                                break;
                            case 3:
                                totalElementos(pila);
                            break;
                            case 4:
                                contiene(pila);
                            break;
                            case 5:
                                Environment.Exit(0);
                            break;
                            default:
                            Console.Write("Ingrese una opccion valida");
                            break;
                        }
                    }catch (FormatException){
                }
                /*Mostramos un mensaje, esperamos a que una tecla sea presionada y limpiamos la consola, para tener
                 un menu limpio*/
                Console.WriteLine("\nPresiona alguna teclado para seguir..."); 
                Console.ReadKey();
                Console.Clear();
            }
        }

        /* M  E  T  O  D  O  S */

        //Metodo insertar, recorremos con un for la pila para agregar los valores ingresados por el usuario
        static void insertarPila(Stack pila,int nElementos){
            for (int i = 0; i < nElementos; i++){                
                Console.Write("Ingresa el valor {0}: ",i+1);
                String agregarElemento = Console.ReadLine();
                pila.Push(agregarElemento);
            }
        }

        //Metodo ver, recorremos por medio de un foreach el arreglo de Stack pila sacando todos los elementos en la listo en forma LIFO
        static void verPila(Stack pila){
            Console.WriteLine("\nLa pila es:");
            foreach(string elemento in pila ){
                Console.Write("{0} ",elemento);
            }
        }

        //Metodo total, nos perminte visualizar el numero total de elementos en la pila
        static void totalElementos(Stack pila){
            Console.WriteLine("Los elementos totales en la pila son: {0}",pila.Count);
        }

        //Metodo contiene, cual buscar dentro de nuestra pila el valor de "buscar"
        static void contiene(Stack pila){
            Console.WriteLine("Digita un valor a buscar:");
            String buscar = Console.ReadLine();
            bool encontrado = pila.Contains(buscar);
            
            // Verficador
            if (encontrado == false){
             Console.WriteLine("No se ha encontrado el valor en la pila");
            }else{
            Console.WriteLine("¿Encontrado?: {0}" ,encontrado);
            }
        }
    }
}

