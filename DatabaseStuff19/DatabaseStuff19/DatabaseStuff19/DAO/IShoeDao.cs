using System;
using System.Collections.Generic;
using System.Text;
using DatabaseStuff19.Models;

namespace DatabaseStuff19.DAO
{
    public interface IShoeDao
    {
        Shoe GetShoe(int shoeId);

        List<string> GetInventory();
    }
}
