/**
 * @file AbstractMethod.cs
 * @author Connor Walsh
 * @date 2023-2-15
 * @brief Widget interface and Decorator abstract class
 * 
 * This file contains the code for the Widget interface and the abstract Decorator class
 */

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
}
