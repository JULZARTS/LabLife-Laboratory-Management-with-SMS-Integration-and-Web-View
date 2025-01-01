using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LabLife.Models
{
    public class MenuItems
    {
        public string? Title { get; set; }
        public string? key { get; set; }
        public Geometry? Icon { get; set; }
        public ICommand command { get; set; }
    }
}
