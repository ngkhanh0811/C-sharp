using System;

sealed class Product
{
    public int Quantity;
    public int Cost;
}

class Goods
{
    static void Main(string[] args)
    {
        Product product = new Product();
        product.Quantity = 50;
        product.Cost = 75;
        Console.WriteLine("Quantity of the product: " + product.Quantity);
        Console.WriteLine("Cost of the product: " + product.Cost);
    }
}

class Pen : Product
{
}