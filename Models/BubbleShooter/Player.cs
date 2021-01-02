using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;
using Excubo.Blazor.Canvas;
using Excubo.Blazor.Canvas.Contexts;

namespace BlazorGames.Models.BubbleShooter
{
    public class Player
    {
        private Context2D ctx;

        public double x { get; set; }
        public double y { get; set; }
        public double radius { get; set; }
        public string color { get; set; }

        public Player(Context2D CanvasContext, int X, int Y, double Radius, string Color)
        {
            ctx = CanvasContext;
            x = X;
            y = Y;
            radius = Radius;
            color = Color;
        }

        public void Draw()
        {
            ctx.BeginPathAsync();
            ctx.ArcAsync(x, y, radius, 0, Math.PI * 2, false);
            ctx.FillStyleAsync(color);
            ctx.FillAsync(FillRule.NonZero);

        }

    }
}
