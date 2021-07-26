﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Contracts
{
    public interface ISqlConnectionFactory
    {
        IDbConnection GetOpenConnection();
    }
}
