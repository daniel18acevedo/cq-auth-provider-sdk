﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQ.AuthProvider.SDK
{
    public interface ISessionService
    {
        Task<SessionCreated> LoginAsync(CreateSessionPassword sessionPassword);
    }
}
