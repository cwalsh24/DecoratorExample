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
        public virtual void draw()
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
        public override void draw()
        {
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
            Console.WriteLine("This is a Scroll Decorator holding a scroll graphic");
        }
    }

    public class BackgroundDecorator : Decorator
    {
        public BackgroundDecorator(Widget w) : base(w)
        {

        }
        public void draw()
        {
            //base(w).draw()? 
            Console.WriteLine("This is a Background Decorator holding a blue background");
        }
    }

    internal class DecoratorDemo
    {
        static void Main(string[] args)
        {
            TextField text = new TextField(10, 10);
            ScrollDecorator scroll = new ScrollDecorator(text);
            BorderDecorator border = new BorderDecorator(text);
            BackgroundDecorator background = new BackgroundDecorator(text);
            scroll.draw();
            border.draw();
            background.draw();
            Console.ReadKey();
        }
    }
}
