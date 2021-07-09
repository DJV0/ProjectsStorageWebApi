using Projects.UI.EasyConsole;
using Projects.UI.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.UI
{
    class MenuProgram : EasyConsole.Program
    {
        private readonly List<Option> menuItems;

        public MenuProgram() : base("Projects", breadcrumbHeader: true)
        {
            menuItems = new List<Option>()
            {
                new Option("Task1", NavigateTo<Task1Page>),
                new Option("Task2", NavigateTo<Task2Page>),
                new Option("Task3", NavigateTo<Task3Page>),
                new Option("Task4", NavigateTo<Task4Page>),
                new Option("Task5", NavigateTo<Task5Page>),
                new Option("Task6", NavigateTo<Task6Page>),
                new Option("Task7", NavigateTo<Task7Page>)
            };

            AddPage(new MainPage(this, menuItems));
            AddPage(new Task1Page(this));
            AddPage(new Task2Page(this));
            AddPage(new Task3Page(this));
            AddPage(new Task4Page(this));
            AddPage(new Task5Page(this));
            AddPage(new Task6Page(this));
            AddPage(new Task7Page(this));

            SetPage<MainPage>();
        }
    }
}
