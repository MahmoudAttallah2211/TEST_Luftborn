using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Repository
{
    public interface IDbInitializer
    {
        /// <summary>
        /// In this interface we implemet the repository design pattern 
        /// and we will use in the next time Interface segregation 
        /// but we just need in this interface to impelement this interface on ths DBinitializer
        /// </summary>
        void Initialize();
    }
}
