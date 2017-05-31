﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Service.IService
{
    public interface ISystemManage : IRepository<SYS_SYSTEM>
    {
        dynamic LoadSystemInfo(List<string> systems);
    }
}
