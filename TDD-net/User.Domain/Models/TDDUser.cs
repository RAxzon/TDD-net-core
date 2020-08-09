using System;
using System.Collections.Generic;
using System.Text;

namespace User.Domain.Models
{
    public class TDDUser
    {

        public int Id { get; protected set; }
        public string Name { get; set; }
        public int Age { get; protected set; }
        public bool IsActive { get; protected set; }

        public TDDUser()
        {

        }

        public TDDUser(int id, string name, int age, bool isActive)
        {
            Id = id;
            Name = name;
            Age = age;
            IsActive = isActive;
        }
    }
}
