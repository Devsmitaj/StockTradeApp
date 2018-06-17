using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradeApp
{/// <summary>
/// User Information
/// </summary>
    class User
    {
        #region
        /// <summary>
        /// Login and Password information
        /// </summary>
        public string Login { get; set; }

        public string Password { get; set; }
        /// <summary>
        /// Account Holder details
        /// </summary>

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        #endregion
    }
}
