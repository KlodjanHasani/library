﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Librarynew.Models
{
    [MetadataType(typeof(AuthorMetaData))]
    public partial class Author
    {
        public class AuthorMetaData
        {
            [DisplayName("Author Name")]

            public string name { get; set; }

            [DisplayName("Address")]

            public string address { get; set; }

            [DisplayName("Phone")]

            public string phone { get; set; }
        }
    }
}