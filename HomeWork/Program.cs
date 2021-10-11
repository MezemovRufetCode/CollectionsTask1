using System;
using System.Collections;
using System.Collections.Generic;
namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            apple.Name = "Apple";
            Pineapple pineapple = new Pineapple();
            pineapple.Name = "Pineapple";
            Lemon lemon = new Lemon();
            lemon.Name = "Lemon";
            apple.Add("Vitamin K");
            apple.Add("Vitamin B6");
            pineapple.Add("Vitamin A");
            pineapple.Add("Vitamin B6");
            pineapple.Add("Vitamin C");           
            pineapple.Add("Vitamin E");
            lemon.Add("Vitamin C");

            Fruit fruit = new Fruit("Orange", "Vitamin C");
            Fruit fruit1 = new Fruit("Banana", "Vitamin B22");
            Fruit fruit2 = new Fruit("Berry", "Vitamin BE");


            #region Trash
            Console.WriteLine("Vitamins of Lemon:");
            foreach (string item in lemon.GetArray())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Vitamins of Apple:");
            foreach (string item in apple.GetArray())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Vitamins of Pineapple:");
            foreach (string item in pineapple.GetArray())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Fruits in basket:");
            #endregion
            ArrayList basket = new ArrayList();
            basket.Add(fruit2.Name);
            basket.Add(fruit1.Name);
            basket.Add(fruit.Name);
            basket.Add(apple.Name);
            basket.Add(lemon.Name);
            basket.Add(pineapple.Name);
            foreach (var item in basket)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}



//1.Apple,  Pineapple və Lemon classları verilir. 
//    Bu meyvələrin özlərinə uyğun vitamin dəyərləri olur.
//    Hər üçünü özündə cəmləyə biləcək bir Basket listi yaradın və 
//    fərqli meyvələri o listə daxil edin.

//apple vit K,B6
//lemon vit C
//pineapple vit C,A,B6,E,K

