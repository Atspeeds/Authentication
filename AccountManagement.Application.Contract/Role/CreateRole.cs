﻿using System.Collections.Generic;

namespace AccountManagement.Application.Contract.Role
{
    public class CreateRole
    {
        public string Name { get; set; }
        public List<PermissionViewModel> permissions { get; set; }
    }
}