using System;
using System.Collections.Generic;
using System.Text;

namespace RearEndCollision
{
    public class GraphicalVisualizer : Visualizer
    {
        public GraphicalVisualizer(IVisualizable mapWithPlayers) : base(mapWithPlayers)
        {
        }

        public override void DisplayMessage(string message)
        {
            throw new NotImplementedException();
        }

        public override void VisualizeNow()
        {
            throw new NotImplementedException();
        }
    }
}
