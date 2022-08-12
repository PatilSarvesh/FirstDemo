using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileIODemo2.DomainException;

namespace FileIODemo2.Data
{
    public class ContactsRepository : IContactRepository
    {
        private readonly string fileName = "d://contact-list.txt";
        public List<Contact> GetAllContacts()
        {
            
            
            //return the list
            StreamReader reader =null;
            List<Contact> contacts = new List<Contact>();

            try
            {
                reader = new StreamReader(fileName);
                while (!reader.EndOfStream)
                {
                    //read line by line

                    string line = reader.ReadLine();
                    string[] data = line.Split(',');

                    //convert line into contact object

                    Contact contact = new Contact();
                    contact.ContactId = int.Parse(data[0]);
                    contact.Name = data[1];
                    contact.EmailId = data[2];
                    contact.MobileNo = data[3];
                    contact.Location = data[4];


                    //add contact obj into list

                    contacts.Add(contact);

                }
            }
            catch(Exception ex)
            {
                UnableToReadContactException ex1=new UnableToReadContactException("Unable to read", ex);
                throw ex1; 
            }
            finally
            {
                if(reader != null)
                reader.Close();
            }



            return contacts;

        }
        public void SaveContact(Contact contactToSave)
        {
            StreamWriter sw = null;
            try
            {
                //open Writer stream
                sw = new StreamWriter(fileName, true);
                string contcatCSV = $"{contactToSave.ContactId},{contactToSave.Name},{contactToSave.EmailId},{contactToSave.MobileNo},{contactToSave.Location}";

                sw.WriteLine(contcatCSV);
            }
            catch(Exception ex)
            {
                //throw new UnableToSaveContactException("angs", ex);
                UnableToSaveContactException ex1 = new UnableToSaveContactException("Contact information is not saved, try again", ex);
                throw ex1;
            }
            finally
            {
                if(sw != null)
                sw.Close();
            }
        
        }

        
    }
}
