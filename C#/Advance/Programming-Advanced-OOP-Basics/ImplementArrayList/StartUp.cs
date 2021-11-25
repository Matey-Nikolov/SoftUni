﻿namespace ImplementArrayList
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            CustomArrayList shopingList = new CustomArrayList();
            shopingList.Add("Tomato");
            shopingList.Add("Bread");
            shopingList.Add("Cheese");
            shopingList.Add("Cucumbers");
            shopingList.Add("Chocolate");
            shopingList.Add(7);
            shopingList.Add("Coke");
            for (int i = 0; i < shopingList.Count; i++)
            {
                Console.WriteLine(shopingList[i]);
            }
            shopingList.Insert(1, "Lemon");
            Console.WriteLine(shopingList.IndexOf("Chocolate"));
            Console.WriteLine(shopingList.Contains("Coke"));
            Console.WriteLine(shopingList[1]);
            Console.WriteLine(shopingList.Count);
            shopingList.Remove(3);
            shopingList.Remove("Tomato");
            Console.WriteLine(shopingList.Count);
        }
    }
}