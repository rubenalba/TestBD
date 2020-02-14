using System;
using System.Collections.Generic;
using System.Text;
using TestBD.Models;

namespace TestBD.Mappers
{
    public static class UserMapper
    {
        public static UserTableEntity toTableUser(this User user)
        {
            return new UserTableEntity
            {
                PartitionKey = "Spain",
                RowKey = user.RowKey,
                Timestamp = user.Timestamp,
                Nombre = user.Nombre,
                Rol = user.Rol
            };
        }

        public static User toUser(this UserTableEntity user)
        {
            return new User()
            {
                Nombre = user.Nombre,
                Rol = user.Rol,
                PartitionKey = user.PartitionKey,
                RowKey = user.RowKey
            };
        }
    }
}
