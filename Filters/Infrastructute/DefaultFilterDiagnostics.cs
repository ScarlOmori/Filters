using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filters.Infrastructute
{
    public class DefaultFilterDiagnostics : IFilterDiagnostics
    {
        private List<string> messages = new List<string>();
        public IEnumerable<string> Messages => messages;

        public void AddMessage(string message)
        {
            messages.Add(message);
        }
    }
}
