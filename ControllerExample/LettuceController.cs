using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleApp.ControllerExample
{
    class LettuceController
    {
        public void makeLettuceRed(Lettuce l)
        {
            l.isGreen = false;
        }
    }
}
