using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Skeleton.Application
{
    public interface IExampleApplication
    {
        string ReturnText(string text);
        
        string ExampleEditor { get; set; }
        
        void SetOption(ExamplePropertyOptions options);
    }
}
