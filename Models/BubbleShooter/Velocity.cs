using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace BlazorGames.Models.BubbleShooter
{
    public class Velocity
    {   
        public double x { get; set; }
        public double y { get; set; }

        public Velocity(double X, double Y)
        {
            x = X;
            y = Y;
        }
    }
}
