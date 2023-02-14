using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPractice
{
    public interface Widget
    {
        void draw();
    }

    public abstract class Decorator : Widget
    {
        Widget wid;
        public Decorator(Widget w)
        {
            wid = w;
        }
        public void draw()
        {
            wid.draw();
        }
    }

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
        public void draw()
        {

        }
    }

    public class ScrollDecorator : Decorator
    {
        public ScrollDecorator(Widget w) : base(w)
        {

        }
        public void draw()
        {

        }
    }

    internal class DecoratorDemo
    {
        static void Main(string[] args)
        {

        }
    }
}
