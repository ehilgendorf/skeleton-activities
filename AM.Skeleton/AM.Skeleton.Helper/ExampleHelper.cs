using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Skeleton.Helper
{
    public class ExampleHelper : IExampleHelper
    {
        public string ReturnText(string text)
        {
            return "This text will be shown: " + text;
        }
    }
}
