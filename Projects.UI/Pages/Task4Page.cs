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
    class Task4Page : Page
    {
        private readonly Service _service;
        public Task4Page(EasyConsole.Program program) : base("Task4", program)
        {
            _service = new Service(new HttpClient());
        }

        public override async Task Display(CancellationToken cancellationToken)
        {
            await base.Display(cancellationToken);

            var result = await _service.GetTeamsWhichMembersAgeOver10Years();
            Output.WriteLine("Teams:");
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
