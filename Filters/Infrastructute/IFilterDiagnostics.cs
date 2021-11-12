using System.Collections.Generic;

namespace Filters.Infrastructute
{
    public interface IFilterDiagnostics 
    {
        IEnumerable<string> Messages { get; }
        void AddMessage(string message);    
    }
}
