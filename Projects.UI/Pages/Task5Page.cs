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
    class Task5Page : Page
    {
        private readonly Service _service;
        public Task5Page(EasyConsole.Program program) : base("Task5", program)
        {
            _service = new Service(new HttpClient());
        }

        public override async Task Display(CancellationToken cancellationToken)
        {
            await base.Display(cancellationToken);

            var result = await _service.GetSortedUsers();
            Output.WriteLine("Users:");
            foreach (var item in result)
            {
                Output.WriteLine($"User:\n{item.User}");
                Output.WriteLine("Tasks:");
                foreach (var task in item.Tasks)
                {
                    Output.WriteLine(task.ToString());
                }
                Output.WriteLine("");
            }

            Output.WriteLine("");
            Input.ReadString("Press [Enter] to exit");
            await Program.NavigateHome(cancellationToken);
        }
    }
}
