﻿using System;
using System.Collections.Generic;

namespace MainProjectEntity.Models
{
    public partial class PasswordReset
    {
        public string? Email { get; set; }
        public string? Token { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
