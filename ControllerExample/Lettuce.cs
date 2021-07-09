using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleApp.ControllerExample
{
    class Lettuce
    {
        LettuceController lettuceController = new LettuceController();
        public bool isGreen = true;

        /// <summary>
        /// Constructor that will be calledw hen you initialize a lettuce class
        /// </summary>
        public Lettuce()
        {
            lettuceController.makeLettuceRed(this);
        }
    }
}
