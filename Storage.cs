using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpReview; 

public class Product {
  private string name;
  private double price;
  private int quantity;

  public Product(string name, double price, int quantity) {
    this.name = name;
    this.price = price;
    this.quantity = quantity;
  }

  // Getters and Setters
  public string Name {
      get => name;
      set => name = value;
  }
  public double Price {
      get => price;
      set => price = value;
  }
  public int Quantity {
      get => quantity;
      set => quantity = value;
  }
}

public class Storage {
  public List<Product> products;
  public DateTime updatedDate;

  public Storage(List<Product> productList, DateTime updatedDate) {
    this.products = productList;
    this.updatedDate = updatedDate;
  }

  // Display Storage Info
  public void displayStorageInfo(){
    Console.WriteLine("Storage updated at : {0}", updatedDate);
    Console.WriteLine("Product / Price / Quantity : ");
    foreach(Product product in products) {
      Console.WriteLine(" {0} | {1} | {2}", product.Name, product.Price, product.Quantity);
    }
    Console.WriteLine();
  }

  // Add and Remove new Products
  public void addProduct(Product product) {
    products.Add(product);
    Console.WriteLine("Product {0} added to the storage", product.Name);
  }
  public void removeProduct(Product product) {
    products.Remove(product);
    Console.WriteLine("Product {0} removed from the storage", product.Name);
  }

  // Add and Remove Quantity of Products
  public void addProductQuantity(Product product, int quantity){
    product.Quantity += quantity;
    Console.WriteLine("Product {0} quantity updated to {1}", product.Name, product.Quantity);
  }
  public void removeProductQuantity(Product product, int quantity) {
    product.Quantity -= quantity;
    Console.WriteLine("Product {0} quantity updated to {1}", product.Name, product.Quantity);
  }
}
/* test inside main program
List<Product> products = new List<Product>();
products.Add(new Product("Brioche", 1.5, 20));
products.Add(new Product("Croissant", 1.2, 15));
products.Add(new Product("Chocolat", 1.8, 10));
products.Add(new Product("Steak", 1.0, 2));
products.Add(new Product("Poulet", 1.0, 20));
products.Add(new Product("Camembert", 1.3, 10));
products.Add(new Product("Yaourt", 1.6, 12));
products.Add(new Product("Emmental", 1.4, 15));
products.Add(new Product("Riz", 0.7, 30));
products.Add(new Product("Pâtes", 0.8, 25));
Storage storage = new Storage(products, DateTime.Now);
storage.displayStorageInfo();
storage.addProduct(new Product("Chips", 1.3, 10));
storage.displayStorageInfo();
storage.removeProduct(products[6]);
storage.displayStorageInfo();
storage.addProductQuantity(products[2], 15);
storage.displayStorageInfo();
storage.removeProductQuantity(products[4], 10);
storage.displayStorageInfo();*/