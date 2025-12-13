using System;
using System.Reflection.Emit;

class Order
{

    private string _customerName;
    private bool _hasTarrif = false;
    private string _totalCost;
    private List<Address> _livesWhere = new List<Address>();
    private List<Product> _coolStuff = new List<Product>();

    public Order(string customerName)
    {
        _customerName = customerName;
    }

    public void AddProduct(string productName, int productID, int productQuantity, float productPriceEach)
    {
        Product p1 = new Product(productName, productID, productQuantity, productPriceEach);
        _coolStuff.Add(p1);
    }

    public void AddAddress(string streetAddress, string city, string state, string zipCode, string country)
    {
        Address a1 = new Address(streetAddress, city, state, zipCode, country);
        _livesWhere.Add(a1);
    }

    public void DisplayOrder()
    {
        Console.WriteLine();
        Console.WriteLine($"Customer: {_customerName}");
        Console.WriteLine();

        int itemCount = 0;
        double subTotal = 0;
        foreach (Product coolStuff in _coolStuff)
        {
            if (itemCount == 0)
            {
                Console.WriteLine($"This order has {_coolStuff.Count} products:");
            }
            itemCount++;
            Console.WriteLine($"{coolStuff.DisplayProducts()} ");
            double tempCost = coolStuff.GetCost();
            subTotal = subTotal + tempCost;

            foreach (Address livesWhere in _livesWhere)
            {
                string tempUSA = livesWhere.DisplayCountry().ToUpper().Trim();
                _hasTarrif = (tempUSA == "USA") ? false : true;
            }
        }
        subTotal = subTotal + 5;
        Console.WriteLine();
        if (_hasTarrif)
        {
            Console.WriteLine($"This order has a tarrif!");
            subTotal = subTotal + 30;
        }
        _totalCost = subTotal.ToString("F2");
        Console.WriteLine($"The total cost of this order is: ${_totalCost}");
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine();
        Console.WriteLine($"Packing List for {_customerName}");
        Console.WriteLine();

        int commentCount = 0;
        foreach (Product coolStuff in _coolStuff)
        {
            if (commentCount == 0)
            {
                Console.WriteLine($"This order has {_coolStuff.Count} products:");
            }
            commentCount++;
            Console.WriteLine($"{coolStuff.DisplayProductsforPackingLabel()} ");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine();
        Console.WriteLine($"Shipping Label: {_customerName}");
        Console.WriteLine();
        Console.WriteLine($"{_customerName}");
        foreach (Address livesWhere in _livesWhere)
        {
            Console.WriteLine($"{livesWhere.DisplayAddress()} ");
        }
        Console.WriteLine();
    }
}