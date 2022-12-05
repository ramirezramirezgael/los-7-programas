using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        Console.WriteLine("bienvenido a tu calculadora de vectores");
        Console.WriteLine("para ir a menu presione ENTER.");
        Console.ReadKey();
        Console.Clear();
        int num = 0;
        int[] vector = new int[10];
        int i = 0;

        while (i < vector.Length)
        {
            Console.WriteLine("ingresa un numero entre 1 y 100");
            num = int.Parse(Console.ReadLine());
            if (num >= 1 && num <= 100)
            {
                vector[i] = num;
                i++;
            }
            else
            {
                Console.WriteLine("numero fuera de rango:");
            }
            Console.ReadKey();
        }
        Console.WriteLine("numeros del vector es:");
        foreach (int temp in vector)
        {
            Console.WriteLine(temp);
        }
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("selecciona el numero que decie hacer con sus vectores:");
        Console.WriteLine("1.intercambiar los elementos de un vector");
        Console.WriteLine("2.ordenar de mayor a menor");
        Console.WriteLine("3.ordenada de manera creciente");
        Console.WriteLine("4.averigua si una lista tiene numeros repetidos");
        Console.WriteLine("5.ordenar de menor a mayor");
        Console.WriteLine("6.averigue si el elmento t esta en la lista");
        Console.WriteLine("7.hallar los elemntos de un vector");
        opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1:

                break;
            case 2:
                Array.Sort(vector);
                Array.Reverse(vector);
                Console.WriteLine("tu vector ordenado es:");
                for (int j = 0; j < vector.Length; j++)
                {
                    Console.WriteLine(vector[j].ToString());
                }
                break;
            case 3:

                let merge_and_ = (Array1, array2) => Array1.concat(array2).sort((a, b) => a - b);  
                let isSorted = (array) => { 
                
                    const array_length = array.length;
                    if (array_length <= 1) return true;
                    for (let index = 0; index < array_length; index++)
                    {
                        if (array[index] > array[index + 1])
                        {
                            return false;
                        }
                    }
                    return true;
                }
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;

        }
    }
}