﻿using System.ComponentModel.DataAnnotations;

namespace ConductManagementSystem
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }



    }
}