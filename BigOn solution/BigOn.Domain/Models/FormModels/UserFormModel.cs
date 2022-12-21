﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigOn.Domain.Models.FormModels
{
    public class UserFormModel
    {
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }    
        
        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Username)|| string.IsNullOrWhiteSpace(Password))
            {
                return false;
            }
            return true;
        }
    }
}
