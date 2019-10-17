using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Domain.Entities
{
    public class User
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public int Cpf { get; set; }
    }
}
