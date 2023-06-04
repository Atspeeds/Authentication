using _01_Framework.Infrastrue;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace _01_Framework.Application
{
    public class NamePermissions
    {
        private readonly IEnumerable<IPermissionExposer> _exposer;
        public NamePermissions(IEnumerable<IPermissionExposer> exposer)
        {
            _exposer = exposer;
        }

        public string GetAcces(List<int> key)
        {
            List<string> permissionsname = new List<string>();
            foreach (var expose in _exposer)
            {
                var expos = expose.Expose();

                foreach (var (keys, value) in expos)
                {
                    foreach (var item in key)
                    {

                        var prmmision = value.FirstOrDefault(x => x.Code == item);

                        if (prmmision != null)
                            permissionsname.Add(prmmision.Name);


                    }

                }
            }
            var resualt = JsonConvert.SerializeObject(permissionsname);

            return resualt;
        }
    }
}
