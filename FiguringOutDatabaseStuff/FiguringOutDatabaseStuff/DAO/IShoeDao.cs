using FiguringOutDatabaseStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguringOutDatabaseStuff.DAO
{
    public interface IShoeDao
    {
        Shoe GetShoe(int shoeId);
    }
}
