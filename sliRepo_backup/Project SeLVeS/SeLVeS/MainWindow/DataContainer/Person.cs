﻿using System;
using System.Collections.Generic;

namespace SelvesSoftware.DataContainer
{
    /// <summary>
    /// author: ZK
    /// </summary>
    public class Person
    {
        public Person()
        {
            HomeAdress = new Adress();
        }

        public long Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String EMail { get; set; }
        public String PhoneNumber { get; set; }
        public String MobilePhone { get; set; }
        public Adress HomeAdress { get; set; }
        public String IBAN { get; set; }
        public String BIC { get; set; }
        public String AccountHolder { get; set; }
        public long SVN { get; set; }
        public String nationality { get; set; }

        public String InfoField { get; set; }

        /// <summary>
        /// Liste der Ansprechpersonen, wenn vorhanden
        /// </summary>
        public Person(String fn, String ln, Adress ad)
        {
            FirstName = fn;
            LastName = ln;
            HomeAdress = ad;
        }
    }
}
