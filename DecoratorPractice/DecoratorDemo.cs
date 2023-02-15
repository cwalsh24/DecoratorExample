/**
 * @file DecoratorDemo.cs
 * @author Connor Walsh
 * @date 2023-2-15
 * @brief decorator pattern driver
 * 
 * This is the driver for the DecoratorPractice program. It contains a main method that tests the functionality 
 * of the decorator classes.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPractice
{
    public class DecoratorDemo
    {
        static void Main(string[] args)
        {
            TextField text = new TextField(10, 10);
            ScrollDecorator scroll = new ScrollDecorator(text);
            BorderDecorator border = new BorderDecorator(scroll);
            BackgroundDecorator background = new BackgroundDecorator(border);
            background.draw();
            Console.ReadKey();
        }
    }
}
