using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4.eiffel
{
    internal class Eiffel 
    {
        public static void cargarDatos(Queue<int> lista)
        {
            string linea;
            bool flag = true;
            int i, k, dato;
            StreamReader sr = new StreamReader(@"C:\Users\Gutie\Desktop\eiffel.txt");
            if (sr != null)
            {
                linea = sr.ReadLine();
                while (linea != null)
                {
                    dato = int.Parse(linea);
                    insercion(lista,dato,ref flag);
                    linea = sr.ReadLine();
                }
            }
            sr.Close();
        }

        private static void agregarPrincipio(Queue<int> lista, int elemento)
        {
            Queue<int> aux = new Queue<int>();
            while (lista.Any())
            {
                aux.Enqueue(lista.Dequeue());
            }
            lista.Enqueue(elemento);
            while (aux.Any())
            {
                lista.Enqueue((int)aux.Dequeue());
            }
        }

        public static void insercion(Queue<int> lista,int dato,ref bool flag)
        {
            if (flag)
            {
                agregarPrincipio(lista, dato);
            }
            else
            {
                lista.Enqueue(dato);
            }
            flag = !flag;
        }

        public static void mostrarDatos(Queue<int> lista)
        {
            int dato;
            Queue<int> aux = new Queue<int>();
            while (lista.Any())
            {
                dato = lista.Dequeue();
                Console.WriteLine(dato);
                aux.Enqueue(dato);
            }
            while (aux.Any())
            {
                lista.Enqueue((int)aux.Dequeue());
            }
        }

        public static int iesima(Queue<int> lista, int dato) //devuelve -1 si no hay dato
        {
            int i,elemento;
            Stack<int> aux = new Stack<int>();
            if (lista.Any() && dato < lista.Count)
            {
                for (i = 0; i < dato; i++)
                {
                    aux.Push((int)lista.Dequeue());
                }
                elemento = lista.Peek(); //devuelve el elemento buscado
                while (aux.Any())  //deja la lista como estaba antes 
                {
                    agregarPrincipio(lista,aux.Pop());
                }
                return elemento;
            }
            else
                return -1;

        }        
        public static int elementos(Queue<int> lista)
        {
            return lista.Count;
        }

        public static void poda(Queue<int> lista)
        {
            _ = lista.Dequeue();
        }

        /*//lo pense mal !!!
        public static void cargaDatos(int[] vec,ref int cant)
        {
            String linea;
            bool flag = true;
            int elemento,i,k;
            cant = i = 0;
            k = vec.Length - 1;
            StreamReader sr = new StreamReader(@"C:\Users\Gutie\Desktop\eiffel.txt");
            if (sr!=null)
            {
                linea = sr.ReadLine();
                while (linea!=null && i<k)
                {
                    cant++;
                    elemento = int.Parse(linea);
                    if (flag)
                    {
                        vec[i++] = elemento;
                    }
                    else
                    {
                        vec[k--] = elemento;
                    }
                    _ = !flag;
                    linea = sr.ReadLine();
                }
            }
            
            sr.Close();
        }

        public static void mostrarDatos(int[] vec,int cant)
        {
            int i,k,h,dato;
            i = 0;
            k = cant;
            bool flag = true;
            for (h=0;h<cant;h++)
            {
                dato = flag ? vec[i++] : vec[k--];

                Console.WriteLine(dato);
            }
        }
        */

    }
}
