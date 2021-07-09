using Projects.UI.EasyConsole;
using Projects.UI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projects.UI.Pages
{
    class Task1Page : Page
    {
        private readonly Service _service;
        public Task1Page(EasyConsole.Program program) : base("Task1", program)
        {
            _service = new Service(new HttpClient());
        }

        public override async System.Threading.Tasks.Task Display(CancellationToken cancellationToken)
        {
            await base.Display(cancellationToken);

            int authorId = Input.ReadInt("Enter author Id:", 0, int.MaxValue);
            Dictionary<Project, int> result = await _service.GetProjectTasksCountByAuthorId(authorId);
            foreach (var item in result)
            {
                Output.WriteLine("Project:");
                Output.WriteLine(item.Key.ToString());
                Output.WriteLine("Project tasks count:");
                Output.WriteLine(item.Value.ToString());
                Output.WriteLine("");
            }

            Input.ReadString("Press [Enter] to exit");
            await Program.NavigateHome(cancellationToken);
        }
    }
}
