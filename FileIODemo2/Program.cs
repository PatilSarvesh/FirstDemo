using FileIODemo2;
using FileIODemo2.Data;


int choice = 1;
Console.WriteLine("Welcome to my Contacts Management System");
Console.WriteLine("-----------------------------------------");

IContactRepository repo = new ContactsRepository();
while (choice != 3)
{
    try
    {
        Console.WriteLine("MENU");
        Console.WriteLine("1. Create Contact");
        Console.WriteLine("2. View All Contacts");
        Console.WriteLine("3. Search By Id");
        
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Contact contact = CollectContactData();
                repo.SaveContact(contact); break;
            case 2:
                List<Contact> contacts = repo.GetAllContacts();
                DisplayAllContacts(contacts); break;
            case 3:
                Console.WriteLine("Enter Id");
                int id = int.Parse(Console.ReadLine());
                List<Contact> contacts1 = repo.GetAllContacts();
                DisplayContactsById(contacts1,id); break;
            
            default:
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static Contact CollectContactData()
{
    Contact c = new Contact();
    Console.Write("Enter Contact ID: ");
    c.ContactId = int.Parse(Console.ReadLine());
    Console.Write("Enter Contact Name: ");
    c.Name = Console.ReadLine();
    Console.Write("Enter Email ID: ");
    c.EmailId = Console.ReadLine();
    Console.Write("Enter Mobile Number: ");
    c.MobileNo = Console.ReadLine();
    Console.Write("Enter Location: ");
    c.Location = Console.ReadLine();
    return c;
}
static void DisplayAllContacts(List<Contact> contacts)
{
    Console.WriteLine("ID \t Name \t Email \t Mobile \t Location");
    foreach (Contact c in contacts)
    {
        Console.WriteLine($"{c.ContactId}\t{c.Name}\t{c.EmailId}\t{c.MobileNo}\t{c.Location}");
    }
}

static void DisplayContactsById(List<Contact> contacts, int Id)
{
    Console.WriteLine("ID \t Name \t Email \t Mobile \t Location");
    foreach (Contact c in contacts)
    {
        if(c.ContactId == Id) { }
        Console.WriteLine($"{c.ContactId}\t{c.Name}\t{c.EmailId}\t{c.MobileNo}\t{c.Location}");
    }
}



