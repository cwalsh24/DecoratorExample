/**
 * @file AbstractMethod.cs
 * @author Connor Walsh
 * @date 2023-2-15
 * @brief Concrete methods for the Decorator program
 * 
 * This file contains the code for the concrete TextField class along with the concerete Decorator methods
 * BorderDecorator, ScrollDecorator, and BackgroundDecorator.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPractice
{
    public class TextField : Widget
    {
        int width;
        int height;
        public TextField(int w, int h)
        {
            w = width;
            h = height;
        }
        public void draw()
        {

        }

    }

    public class BorderDecorator : Decorator
    {
        public BorderDecorator(Widget w) : base(w)
        {

        }
        public override void draw()
        {
            base.draw();
            Console.WriteLine("This is a Border Decorator holding an orange border");
        }
    }

    public class ScrollDecorator : Decorator
    {
        public ScrollDecorator(Widget w) : base(w)
        {

        }
        public override void draw()
        {
            base.draw();
            Console.WriteLine("This is a Scroll Decorator holding a sparkle scroll graphic");
        }
    }

    public class BackgroundDecorator : Decorator
    {
        public BackgroundDecorator(Widget w) : base(w)
        {

        }
        public override void draw()
        {
            base.draw();
            Console.WriteLine("This is a Background Decorator holding a blue background");
        }
    }
}
