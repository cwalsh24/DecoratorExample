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
        Decorator(Widget w)
        {
            w = wid;
        }
        public void draw()
        {

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

    public class BorderDecorator : Widget
    {
        public BorderDecorator(Widget w)
        {

        }
        public void draw()
        {

        }
    }

    public class ScrollDecorator : Widget
    {
        public ScrollDecorator(Widget w)
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
