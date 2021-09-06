using System;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;

public class Product
{
    public string NameOfProduct { get; set; }
    public double Price { get; set; }
}
public class ShoppingCart
{
    public int _itemCount; // количество предметов в корзине
    private double _totalPrice; // цена всех предметов в корзине
    private int _capacity; // текущая вместимость корзины
    private Product[] cart;

    /// <summary>
    /// Создаёт новый экземпляр корзины с вместимостью в 5 элементов
    /// </summary>
    public ShoppingCart()
    {
        _capacity = 5;
        _itemCount = 0;
        _totalPrice = 0.0;
        cart = new Product[_capacity];
    }

    public Product this[int index]
    {
        get => cart[index];
        set => cart[index] = value;
    }


    /// <summary>
    /// Добавляет предмет в корзину
    /// </summary>
    /// <param name="itemName">Название предмета</param>
    /// <param name="price">Цена предмета</param>
    public void AddToCart(string itemName, double price)
    {
        if (_itemCount + 1 == _capacity)
        {
            throw new ArgumentException("_Cart is full.");
        }

        this[_itemCount++] = new Product { NameOfProduct = itemName, Price = price };
    }

    /// <summary>
    /// Увеличивает вместимость корзины на 3
    /// </summary>
    public void IncreaseSize()
    {
        Array.Resize(ref cart, cart.Length + 3);
    }

    /// <summary>
    /// Возвращает предметы в корзине с дополнительной информацией
    /// </summary>
    public override string ToString()
    {
        string contents = "\nShopping Cart\n";

        contents += "\nItem\t\tUnit Price\tQuantity\tTotal\n";

        for (int i = 0; i < _itemCount; i++)
            contents += cart[i] + "\n";

        contents += $"\nTotal Price: {_totalPrice:C}\n";

        return contents;
    }
}

public class Program
{
    private static void Main()
    {
        var newCart = new ShoppingCart();
        do
        {
            Console.Clear();
            try
            {
                Console.Write("Enter the name of the product: ");
                var nameProduct = Console.ReadLine();
                double price;
                do
                {
                    Console.Write("Enter the price of this product: ");
                } while (!double.TryParse(Console.ReadLine(), out price));

                newCart.AddToCart(nameProduct, price);

                Console.WriteLine("Product in your cart:");
                for (var i = 0; i < newCart._itemCount; i++)
                {
                    Console.WriteLine($"Name of product: {newCart[i].NameOfProduct}");
                    Console.WriteLine($"Price of product: {newCart[i].Price}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Size of cart will increase up 3.");
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу на клавиатуре. Для выхода из программы веди \"Escape\"");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
