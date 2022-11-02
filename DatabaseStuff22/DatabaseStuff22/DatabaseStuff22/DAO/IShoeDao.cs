using DatabaseStuff22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseStuff22.DAO
{
    public interface IShoeDao
    {
        Shoe GetShoe(int shoeId);

        List<string> GetInventory();
    }
}
