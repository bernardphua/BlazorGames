using Excubo.Blazor.Canvas;
using Excubo.Blazor.Canvas.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGames.Models.BubbleShooter
{
    public class Enemy
    {
        private Batch2D ctx;

        public double x { get; set; }
        public double y { get; set; }
        public double radius { get; set; }
        public string color { get; set; }
        public Velocity velocity { get; set; }

        public Enemy(double X, double Y, double Radius, string Color, Velocity Velocity)
        {
            x = X;
            y = Y;
            radius = Radius;
            color = Color;
            velocity = Velocity;
        }

        public void Draw()
        {
            ctx.BeginPathAsync();
            ctx.ArcAsync(x, y, radius, 0, Math.PI * 2, false);
            ctx.FillStyleAsync(color);
            ctx.FillAsync(FillRule.NonZero);
        }

        public void Update(Batch2D CanvasContext)
        {
            ctx = CanvasContext;
            Draw();
            x = x + velocity.x;
            y = y + velocity.y;
        }
    }
}
