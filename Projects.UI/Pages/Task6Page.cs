using Projects.UI.EasyConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projects.UI.Pages
{
    class Task6Page : Page
    {
        private readonly Service _service;
        public Task6Page(EasyConsole.Program program) : base("Task6", program)
        {
            _service = new Service(new HttpClient());
        }

        public override async Task Display(CancellationToken cancellationToken)
        {
            await base.Display(cancellationToken);

            int userId = Input.ReadInt("Enter user Id:", 0, int.MaxValue);
            var result = await _service.GetTask6(userId);
            Output.WriteLine($"Result:\n{result}");

            Output.WriteLine("");
            Input.ReadString("Press [Enter] to exit");
            await Program.NavigateHome(cancellationToken);
        }
    }
}
