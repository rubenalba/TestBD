using System;
using System.Collections.Generic;
using System.Text;

namespace TestBD.Models
{
    public class User
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
