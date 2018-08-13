﻿using System;
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
        #region Properties
        /// <summary>
        /// Login and Password information
        /// </summary>
        public string UserId { get; set; }

        public string Password { get; set; }
        /// <summary>
        /// Account Holder details
        /// </summary>

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
       #endregion


        #region Method
        public bool Register(string Id, string Pswd, string FName, string MName, string LName, DateTime DOB, string Addr)
        {
            bool registered = true;
            UserId = Id;
            Password = Pswd;
            FirstName = FName;
            MiddleName = MName;
            LastName = LName;
            DateOfBirth = DOB;
            Address = Addr;
            return registered;
        }
        public bool Update(string Password, string FName, string MName, string LName, DateTime DOB, string Addr)
        {
            bool updated = true;
            FirstName = FName;
            MiddleName = MName;
            LastName = LName;
            DateOfBirth = DOB;
            Address = Addr;
            return updated;
        }
        #endregion
        }
}
