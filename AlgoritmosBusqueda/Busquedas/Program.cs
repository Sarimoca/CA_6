using System;
using BusquedaAlgoritmos;

namespace BusquedaAlgoritmos
{
    public class Busquedas
    {
        // Búsqueda lineal (funciona con arreglos ordenados o no ordenados)
        public static int BusquedaLineal(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1; // Retorna -1 si no se encuentra el elemento
        }

        // Búsqueda binaria (requiere que el arreglo esté ordenado)
        public static int BusquedaBinaria(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1; // Retorna -1 si no se encuentra el elemento
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

