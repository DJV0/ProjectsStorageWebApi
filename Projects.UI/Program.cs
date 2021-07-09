using System;
using System.Threading;
using System.Threading.Tasks;

namespace Projects.UI
{
    class Program
    {
        static Task Main(string[] args)
        {
            return new MenuProgram().Run(CancellationToken.None);
        }
    }
}
