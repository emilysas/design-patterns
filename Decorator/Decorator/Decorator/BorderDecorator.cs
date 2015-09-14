using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Decorator
{
    class BorderDecorator : IVisualComponent
    {
        private int _width;
        private IVisualComponent _wrapped;

        public BorderDecorator(IVisualComponent wrapped, int width)
        {
            _wrapped = wrapped;
            _width = width;
        }

        public void Draw()
        {
            _wrapped.Draw();
            GUI.DrawBorder(_width);
        }
    }
}
