using Projects.UI.EasyConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.UI.Pages
{
    class MainPage : MenuPage
    {
        public MainPage(EasyConsole.Program program, List<Option> menuItems) : base("Меню", program, menuItems.ToArray())
        {
        }
    }
}
