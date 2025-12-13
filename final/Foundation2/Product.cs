using System;
using System.Runtime.CompilerServices;

class Product
{
    private string _productName;
    private int _productID;
    private int _productQuantity;
    private float _productPriceEach;

    public Product(string productName, int productID, int productQuantity, float productPriceEach)
    {
        _productName = productName;
        _productID = productID;
        _productQuantity = productQuantity;
        _productPriceEach = productPriceEach;
    }

    public string DisplayProducts()
    {
        string tempText = "" + _productName + "     SKU: " + _productID + "     Quantity: " + _productQuantity + "     Unit Price: $" + _productPriceEach.ToString("F2");
        return tempText;
    }

    public string DisplayProductsforPackingLabel()
    {
        string tempText = "" + _productName + "     SKU: " + _productID + "     Quantity: " + _productQuantity;
        return tempText;
    }

    public double GetCost()
    {
        float orderCost = _productPriceEach * _productQuantity;
        return orderCost;
    }
}