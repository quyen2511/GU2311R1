﻿using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int size=0;
        do
        {
          Console.WriteLine("Nhap kich thuoc mang");
          size = int.Parse(Console.ReadLine());
          if(size>20) Console.WriteLine("Gia tri nhap qua 20 yeu cau nhap lai");

        } while (size>20);
        int[] array = new int[size];
        Console.WriteLine("Nhap phan tu cua mang");   //nhap cac phan tu cua mang
       
        int j=0;
        while (j<=array.Length-1)
        {
            array[j]= int.Parse(Console.ReadLine());
            j++;
        }
        Console.WriteLine("Gia tri cac phan tu cua mang la:");  //in ra cac phan tu mang
        for (int i = 0; i <=array.Length-1; i++)
        {
            Console.Write(array[i]+"\t");
        }
        int max = array[0];                       //tim gia tri lon nhat cua mang
        int indextArrayList=0;
        for (int i = 0; i <= array.Length-1; i++)             //1--->n  chi so 0-->n-1
        {
            if(array[i]>max) 
            {
            max = array[i];
            indextArrayList = i+1;
            }
        }
        Console.WriteLine("Gia tri loan nhat la "+ max + "co vi tri "+ indextArrayList);
    }
}