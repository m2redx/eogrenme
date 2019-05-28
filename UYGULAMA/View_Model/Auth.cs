using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UYGULAMA.View_Model
{
    public class AuthIndex 
    {
      public int userId { get; set; }
       // [DataType(DataType.Password)]
        public string password { get; set;}

    }
}