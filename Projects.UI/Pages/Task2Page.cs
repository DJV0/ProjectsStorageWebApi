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
    class Task2Page : Page
    {
        private readonly Service _service;
        public Task2Page(EasyConsole.Program program) : base("Task2", program)
        {
            _service = new Service(new HttpClient());
        }

        public override async System.Threading.Tasks.Task Display(CancellationToken cancellationToken)
        {
            await base.Display(cancellationToken);

            int performerId = Input.ReadInt("Enter performer Id:", 0, int.MaxValue);
            var result = await _service.GetPerformerTasks(performerId);
            Output.WriteLine("Tasks:");
            foreach (var item in result)
            {
                Output.WriteLine(item.ToString());
            }

            Output.WriteLine("");
            Input.ReadString("Press [Enter] to exit");
            await Program.NavigateHome(cancellationToken);
        }
    }
}
