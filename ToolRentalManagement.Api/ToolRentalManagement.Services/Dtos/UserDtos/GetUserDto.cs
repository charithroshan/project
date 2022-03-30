﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolRentalManagement.Services.Dtos.UserDtos
{
    public class GetUserDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }
        
    }
}
