using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleApp.ControllerExample
{
    class Lettuce
    {
        LettuceController lettuceController = new LettuceController();
        public bool isGreen = true;

        public Lettuce()
        {
            lettuceController.makeLettuceRed(isGreen);
        }
    }
}
