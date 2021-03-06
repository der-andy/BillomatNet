﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace BillomatNet.Data
{
    /// <summary>
    /// Represents a Billomat user (employee of your company)
    /// </summary>
    [BillomatResource("users", "user", "users", Flags = BillomatResourceFlags.NoCreate | BillomatResourceFlags.NoDelete | BillomatResourceFlags.NoUpdate)]
    public class BillomatUser : BillomatObject<BillomatUser>
    {
        [BillomatField("email")]
        [BillomatReadOnly]
        public string EMail { get; set; }

        [BillomatField("first_name")]
        [BillomatReadOnly]
        public string FirstName { get; set; }

        [BillomatField("last_name")]
        [BillomatReadOnly]
        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        /// <summary>
        /// Finds all users that match the specified criteria
        /// </summary>
        /// <param name="email">search for e-mail address</param>
        /// <param name="firstName">search for first name</param>
        /// <param name="lastName">search for last name</param>
        /// <returns></returns>
        public static List<BillomatUser> FindAll(string email = null, string firstName = null,
                                                 string lastName = null)
        {
            var parameters = new NameValueCollection();

            if (!string.IsNullOrEmpty(email))
            {
                parameters.Add("email", email);
            }
            if (!string.IsNullOrEmpty(firstName))
            {
                parameters.Add("first_name", firstName);
            }
            if (!string.IsNullOrEmpty(lastName))
            {
                parameters.Add("last_name", lastName);
            }

            return FindAll(parameters);
        }

        /// <summary>
        /// Returns a dictionary containing all users: (user ID => user object)
        /// </summary>
        /// <returns></returns>
        public new static Dictionary<int, BillomatUser> GetList()
        {
            return BillomatObject<BillomatUser>.GetList();
        }

        /// <summary>
        /// Returns the user that is currently using the API
        /// </summary>
        /// <returns></returns>
        public static BillomatUser FindMyself()
        {
            var req = new BillomatRequest
                          {
                              Resource = "users",
                              Method = "myself"
                          };

            return CreateFromXml(req.GetXmlResponse());
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", FullName, EMail);
        }
    }
}