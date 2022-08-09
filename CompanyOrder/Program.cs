// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Company company = new Company();
Item i1 = new Item { Rate =100};
Item i2 = new Item { Rate =200};
Item i3 = new Item { Rate =2300};
Item i4 = new Item { Rate =500};
Item i5 = new Item { Rate =2040};

company.Items.Add(i1);
company.Items.Add(i2);
company.Items.Add(i3);
company.Items.Add(i4);
company.Items.Add(i5);
//company.Items.Add(i1);



Customer c1 = new Customer();
company.Customers.Add(c1);

RegCustomer c2 = new RegCustomer();
c2.Discount = 10;
company.Customers.Add(c2);

Order o1= new Order();
c1.orders.Add(o1);

OrderedItem orderedItem = new OrderedItem { quantity = 1, Item = i1};
o1.OrderedItems.Add(orderedItem);

Console.WriteLine($"Total Worth {company.GetTotalWortOfOrdersPlaced()}");

public class Item
{
    public string Description { get; set; }
    public int Rate { get; set; }

}

public class Company
{
    public List<Item> Items { get; set; } = new List<Item>();

    public List<Customer> Customers { get; set; } = new List<Customer>();

    public double GetTotalWortOfOrdersPlaced()
    {
        double total = 0;
        foreach (Customer customer in Customers)

        {
            foreach(Order order in customer.orders)
            {
                foreach(OrderedItem oItem in order.OrderedItems)
                {
                    total += oItem.quantity * oItem.Item.Rate;
                }
            }
            if(customer is RegCustomer)
            {
                //down cast to access the discount
                RegCustomer reg = customer as RegCustomer;
                double totalDiscount = 0;
                totalDiscount= reg.Discount * total / 100;

                total = total - totalDiscount;
            }
        }
        return total;
    }

}

public class Customer
{
    public List<Order> orders { get; set; } = new List<Order>();
}

public class RegCustomer : Customer
{
    public double Discount { get; set; }
}

public class Order
{
    public List<OrderedItem> OrderedItems { get; set; } = new List<OrderedItem>();
}

public class OrderedItem
{
    public int quantity { get; set; }
    public Item Item { get; set; }
}
