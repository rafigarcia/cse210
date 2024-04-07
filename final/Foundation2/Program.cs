using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("552ft Wall Street", "Chicago", "IL", "USA");
        Address address2 = new Address("456 Oak Ave", "San Francisco", "CA",  "USA");
        Address address3 = new Address("789 Pine St", "New York", "NY", "USA");
        Address address4 = new Address("101 River Road", "Austin", "TX",  "USA");
        Address address5 = new Address("202 Lake Blvd", "Minneapolis", "MN",  "USA");
        Address address6 = new Address("303 Hill St", "Seattle", "WA",  "USA");
        Address address7 = new Address("404 Valley View", "Cozumel", "AZ",  "MEXICO");


        Customer customer1 = new Customer("Martha Samboa", address1);
        Customer customer2 = new Customer("Emma Stone", address2);
        Customer customer3 = new Customer("Oliver Twist", address3);    
        Customer customer4 = new Customer("Sophia Loren", address4);
        Customer customer5 = new Customer("James Bond", address5);
        Customer customer6 = new Customer("Mia Wallace", address6);
        Customer customer7 = new Customer("Harry Potter", address7);


        Product product1 = new Product("UltraHD 4K TV", "TV001", 999.99, 30);
        Product product2 = new Product("Bluetooth Speaker", "SPK002", 149.99, 50);
        Product product3 = new Product("Smartphone X12", "PHN003", 799.99, 100);
        Product product4 = new Product("Laptop Pro 15", "LTP004", 1299.99, 40);
        Product product5 = new Product("Ergonomic Keyboard", "KYB005", 59.99, 150);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Order order3 = new Order(customer3);
        order3.AddProduct(product5);
        order3.AddProduct(product5);

        Order order4 = new Order(customer4);
        order4.AddProduct(product1);
        order4.AddProduct(product2);
        order4.AddProduct(product5);
        order4.AddProduct(product5);

        Order order5 = new Order(customer5);
        order5.AddProduct(product1);
        order5.AddProduct(product4);
        order5.AddProduct(product3);

        Order order6 = new Order(customer6);
        order6.AddProduct(product1);
        order6.AddProduct(product4);
        
        Order order7 = new Order(customer7);
        order7.AddProduct(product4);


        List<Order> orders = new List<Order>
        {
            order1, order2, order3, order4, order5, order6, order7
        };

        for (int i = 0; i < orders.Count; i++)
        {
            Order order = orders[i];
            Console.WriteLine();
            Console.WriteLine("Order #{0}", i + 1);
            Console.WriteLine("Customer: {0}", order.GetCustomer());
            Console.WriteLine("Total Price: {0}", order.GetTotalPrice());
            Console.WriteLine("Packing Label: {0}", order.GetPackingLabel());
            Console.WriteLine("Shipping Label: {0}", order.GetShippingLabel());
            
        }
    }
}