using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestBD.Models
{
     public class UserTableEntity : TableEntity
    {
        public string Nombre { get; set; }
        public string Rol { get; set; }
    }
}
