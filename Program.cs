using System;
using System.Collections.Generic;
class Program 
{
    public static void Main(string[] args){
        Guitar [] guitars = InputGuitar();

        PrintGuitarInfomation(guitars);
    } 
    
    public static Guitar [] InputGuitar(){
        Guitar [] guitars = new Guitar[5];

        for(int index = 0; index < guitars.Length; index++){
            Console.WriteLine("******************Input Serialnumber : {0}************************", index + 1);
            Guitar guitar = new Guitar(InputSerialNumber(), InputPrice(), InputBuilder(), InputModel(), InputWood());

            guitars[index] = guitar;

            Console.WriteLine("*****************************************************************");
            Console.WriteLine();
        }

        return guitars;
    }

    public static void PrintGuitarInfomation(Guitar [] guitar){
        Array.ForEach(guitar, guitar => Console.WriteLine(guitar.PrintGuitarInfomation()));
    }

    public static string InputSerialNumber(){
        Console.WriteLine("Input Serialnumber : ");
        string S = Console.ReadLine();

        return S; 
    }
    public static string InputPrice(){
        Console.WriteLine("Input Price : ");
        string P = Console.ReadLine();

        return P;
    }
    public static string InputBuilder(){
        Console.WriteLine("Input Builder : ");
        string B = Console.ReadLine();

        return B;
    }
    public static string InputModel(){
        Console.WriteLine("Input Model : ");
        string M = Console.ReadLine();

        return M;
    }
    public static string InputWood(){
        Console.WriteLine("Input Wood : ");
        string W = Console.ReadLine();

        return W;
    }
}
