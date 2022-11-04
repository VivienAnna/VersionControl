using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMaintenance.Abstractions;

namespace UserMaintenance.Entities
{
    public class PresentFactory : IToyFactory
    {
        public Color Box { get; set; }
        public Color Ribbon { get; set; }
        public Toy CreateNew()
        {
            return new Present(Ribbon, Box);
        }
    }
}
