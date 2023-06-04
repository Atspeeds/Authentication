using System;
using System.Collections.Generic;

namespace _01_Framework.Infrastrue
{
    public interface IPermissionExposer
    {
        Dictionary<string, List<PermissionDto>> Expose();
    }
}
