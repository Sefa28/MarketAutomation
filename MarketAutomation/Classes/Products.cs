using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAutomation.Classes
{
    public  class Products
    {
        public static List<Classes.Products> ProductList = new List<Classes.Products>();
        public static dynamic[,] matris = new dynamic[50, 50];

        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public int NumberOfPieces { get; set; }
        public int Price { get; set; }
        public string category { get; set; } 
        public string[] categoryinfo = {"Fruits and Vegetables", "Basic Food", "Snack", "Drinks" };



        public int productNumberofRegistrations;
        public void NumberofRegistrations(int number)
        {
            productNumberofRegistrations = number;
        }


        public void tomato()
        {
            ProductId = 1;
            ProductName = "Tomato";  
            NumberOfPieces = 3;
            category = "Fruits and Vegetables";
            Price = 15;         
        }
        public void pepper()
        {
            ProductId = 2;
            ProductName = "Pepper";
            NumberOfPieces = 1;    
            category = "Fruits and Vegetables";
            Price = 5;             
        }
        public void eggplant()
        {
            ProductId = 3;
            ProductName = "Eggplant";
            NumberOfPieces = 2;
            category = "Fruits and Vegetables";
            Price = 10;
        }
        public void pasta()
        {
            ProductId = 4;
            ProductName = "Pasta";
            NumberOfPieces = 1;
            category = "Basic Food";
            Price = 20;
        }
        public void rice()
        {
            ProductId = 5;
            ProductName = "Rice";
            NumberOfPieces = 1;
            category = "Basic Food";
            Price = 40;
        }
        public void sugar()
        {
            ProductId = 6;
            ProductName = "Sugar";
            NumberOfPieces = 1;
            category = "Basic Food";
            Price = 50;
        }
        public void chips()
        {
            ProductId = 7;
            ProductName = "Chips";
            NumberOfPieces = 1;
            category = "Snack";
            Price = 15;
        }
        public void chocolate()
        {
            ProductId = 8;
            ProductName = "Chocolate";
            NumberOfPieces = 1;
            category = "Snack";
            Price = 25;
        }
        public void sunflowerseed()
        {
            ProductId = 9;
            ProductName = "Sunflower Seed";
            NumberOfPieces = 1;
            category = "Snack";
            Price = 40;
        }
        public void water()
        {
            ProductId = 10;
            ProductName = "Water";
            NumberOfPieces = 1;
            category = "Drink";
            Price = 10;
        }
        public void milk()
        {
            ProductId = 11;
            ProductName = "Milk";
            NumberOfPieces = 1;
            category = "Drink";
            Price = 15;
        }
        public void ayran()
        {
            ProductId = 12;
            ProductName = "Ayran";
            NumberOfPieces = 1;
            category = "Drink";
            Price = 10;
        }
        public void btn7()
        {
            ProductId = Classes.Products.matris[0, 0];
            ProductName = Classes.Products.matris[0, 1];
            NumberOfPieces = Classes.Products.matris[0, 2];
            Price = Classes.Products.matris[0, 3];
            category = Classes.Products.matris[0, 4];
        }
        public void btn8()
        {
            ProductId = Classes.Products.matris[1, 0];
            ProductName = Classes.Products.matris[1, 1];
            NumberOfPieces = Classes.Products.matris[1, 2];
            Price = Classes.Products.matris[1, 3];
            category = Classes.Products.matris[1, 4];
        }
        public void btn9()
        {
            ProductId = Classes.Products.matris[2, 0];
            ProductName = Classes.Products.matris[2, 1];
            NumberOfPieces = Classes.Products.matris[2, 2];
            Price = Classes.Products.matris[2, 3];
            category = Classes.Products.matris[2, 4];
        }
            //ProductId = Classes.Products.matris[3, 0];
            //ProductName = Classes.Products.matris[3, 1];
            //NumberOfPieces = Classes.Products.matris[3, 2];
            //Price = Classes.Products.matris[3, 3];
            //category = Classes.Products.matris[3, 4];



    }

}
