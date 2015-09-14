using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
	public class ScrollDecorator : IVisualComponent
    {
        private int _topLine;
        private IVisualComponent _wrapped;

		public ScrollDecorator(IVisualComponent wrapped, int topLine)
		{
		    _wrapped = wrapped;
            _topLine = topLine;
        }

        public void Draw()
        {
            _wrapped.Draw();
			GUI.DrawScrollBar(_topLine);
        }
    }
}
