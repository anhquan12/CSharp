using System;
using System.Collections.Generic;

namespace Practicle
{
    class Program
    {
        static void Main(string[] args)
        {
            test();
        }

        static void test()
        {
            List<Product> list = new List<Product>();
            
            Book book = new Book();
            book.id = "Book1";
            book.name = "JAVA";
            book.price = 100;
            book.producer = "Java";
            
            Book book1 = new Book();
            book1.id = "Book2";
            book1.name = "C++";
            book1.price = 150;
            book1.producer = "C++";
            
            Book book2 = new Book();
            book2.id = "Book3";
            book2.name = "C#";
            book2.price = 70;
            book2.producer = "C#";
            
            MobilePhone mobilePhone = new MobilePhone();
            mobilePhone.id = "MobilePhone1";
            mobilePhone.name = "Nokia";
            mobilePhone.price = 1000;
            mobilePhone.producer = "Nokia";
            
            MobilePhone mobilePhone1 = new MobilePhone();
            mobilePhone1.id = "MobilePhone2";
            mobilePhone1.name = "Iphone";
            mobilePhone1.price = 1200;
            mobilePhone1.producer = "Apple";
            
            MobilePhone mobilePhone2 = new MobilePhone();
            mobilePhone2.id = "MobilePhone3";
            mobilePhone2.name = "Samsung";
            mobilePhone2.price = 1100;
            mobilePhone2.producer = "Samsung";
            
            list.Add(book);
            list.Add(book1);
            list.Add(book2);
            list.Add(mobilePhone);
            list.Add(mobilePhone1);
            list.Add(mobilePhone2);

            double? price = null;
            foreach (var product in list)
            {
                price = product.computeTax();
                price += price;
            }
            Console.WriteLine(price);
        }
    }
}