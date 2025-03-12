using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
namespace ProyectoPooVF
{
    class Program
    {
        static void Main(string[] args)
        {
            //1	Creación e inicialización de un arreglo:
            int[] aiNumeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //Declaramos e inicializamos un arreglo de 10 elementos (1-10)
            Console.WriteLine("Los números de nuestro arreglo son: ");
            PrintArray(aiNumeros); //Llamamos a la función PrintArray e imprimimos el arreglo aiNumeros

            //2 Modificación de un elemento
            Console.WriteLine("Ingresa un número para modificar el tercer elemento: ");//Pedimos al usuario que ingrese un número que modifique el indice 2
            int iValor;
            while (!int.TryParse(Console.ReadLine(), out iValor))
            {  //Validamos que el valor ingresado sea un número
                Console.WriteLine("Por favor, ingresa un número válido: ");
            }
            aiNumeros[2] = iValor; //Modificamos el tercer elemento del arreglo con el valor ingresado por el usuario
            Console.WriteLine("Arreglo actualizado");
            PrintArray(aiNumeros); //Imprimimos el arreglo actualizado

            //3 Suma de los elementos del arreglo:
            int iSuma = 0; //Declaramos una variable para almacenar la suma de los elementos del arreglo
            for (int i = 0; i < aiNumeros.Length; i++) //Recorremos el arreglo y sumamos cada uno de sus elementos
            {
                iSuma += aiNumeros[i];
            }
            Console.WriteLine("La suma de los elementos del arreglo es: " + iSuma); //Imprimimos la suma de los elementos del arreglo

            //4 Búsqueda de un número en el arreglo:
            Console.WriteLine("Ingresa un número para que lo busquemos en el Array: ");
            int iBusqueda;
            while (!int.TryParse(Console.ReadLine(), out iBusqueda)){  //Validamos que el valor ingresado sea un número
                Console.WriteLine("Por favor, ingresa un número válido: ");
            }
            int iPosicion = Array.IndexOf(aiNumeros, iBusqueda); //Buscaremos el número ingresado por el usuario en el arreglo
            if (iPosicion != -1)
            {
                Console.WriteLine("El número " + iBusqueda + " se encuentra en la posición " + iPosicion + " del arreglo.");
            }else{
                Console.WriteLine("El número " + iBusqueda + " no se encuentra en el arreglo.");
            }//Si el número se encuentra en el arreglo, imprimimos su posición, pero si no esta en el arreglo, imprimimos un mensaje que nos lo indique
        }
        static void PrintArray(int[] arr) ///Función auxiliar que imprime nuestro arreglo
        {
            for (int i = 0; i < arr.Length; i++)//Recorremos el arreglo y lo imprimimos
            {
                Console.Write(arr[i] + " "); //Imprimimos el elemento en la posición i
            }
           Console.WriteLine();//Imprimimos un salto de línea
        }

    }
}
