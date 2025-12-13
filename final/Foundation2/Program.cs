using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // This is the product ordering program written by Chris Johnson in December 2025.
        // This is the Main method of the Program Class.
        // This class handles providing customer,order and address information to the corresponding classes.
        // The Order, Product, Customer, and Address classes convert the data into objects and provides a way to display our Orders.

        Console.WriteLine();
        Console.WriteLine("Welcome to the Product Ordering Program");

        Order o1 = new Order("Kitchen Kate");
        o1.AddAddress("320 S 500 E", "Mount Pleasant", "UT", "84647", "usa");
        o1.AddProduct("Waffle Maker", 1403, 2, 69.48f);
        o1.AddProduct("Kitchenaid Mixer", 1452, 1, 309.99f);
        o1.AddProduct("Spatula", 1232, 5, 12.95f);

        Order o2 = new Order("Garage Gary");
        o2.AddAddress("2424 W 2950 N", "Ogden", "Utah", "84404", "USA");
        o2.AddProduct("Ratchet set", 987, 1, 128.45f);
        o2.AddProduct("Brake pads", 934, 1, 32.95f);


        Order o3 = new Order("Artist Maria");
        o3.AddAddress("Calle Rivera Navarrete 737", "Lima", "San Isidro", "15046", "Peru");
        o3.AddProduct("Canvas 8X10", 3850, 5, 18.45f);
        o3.AddProduct("Canvas 4X6", 3855, 10, 8.95f);
        o3.AddProduct("Paint Brush Kit", 3356, 1, 15.50f);

        Console.WriteLine("The following orders have been placed.");

        o1.DisplayOrder();
        o1.DisplayPackingLabel();
        o1.DisplayShippingLabel();
        o2.DisplayOrder();
        o2.DisplayPackingLabel();
        o2.DisplayShippingLabel();
        o3.DisplayOrder();
        o3.DisplayPackingLabel();
        o3.DisplayShippingLabel();

        Console.WriteLine();
        Console.WriteLine("This is the end");
        Console.WriteLine();
    }
}