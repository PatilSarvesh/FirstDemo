using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo2.Data
{
    public interface IContactRepository
    {
        void SaveContact(Contact contactToSave);
        List<Contact> GetAllContacts();

    }
}
