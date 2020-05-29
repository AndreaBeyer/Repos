using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryInterfacePersistanceMetier
{
    public interface IPersitanceContact
    {
        int AddContact(StructContact contact);
        bool UpdateContact(StructContact contact);
        bool DeleteContact(StructContact contact);
        StructContact GetContact(int id);

    }
}
