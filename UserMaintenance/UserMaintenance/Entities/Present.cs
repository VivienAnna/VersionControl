﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMaintenance.Abstractions;

namespace UserMaintenance.Entities
{
    public class Present : Toy
    {
        public SolidBrush Ribbon { get; private set; }
        public SolidBrush Box { get; private set; }

        public Present(Color ribbon, Color box)
        {
            Ribbon = new SolidBrush(ribbon);
            Box = new SolidBrush(box);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(Box, 0, 0, Width, Height);
            g.FillRectangle(Ribbon, 0, Height/2-5, Width, Height/5);
            g.FillRectangle(Ribbon, Width/2-5, 0, Width/5, Height); 
        }
    }
}
