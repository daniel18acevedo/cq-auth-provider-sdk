﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQ.AuthProvider.SDK
{
    public record class CqAuthErrorApi
    {
        public string Code { get; set; }

        public string Message { get; set; }
    }
}