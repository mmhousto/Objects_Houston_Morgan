using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_Houston_Morgan
{
    interface IBootUp
    {

        public bool IsOn { get; set; }

        public void PowerOnOff();

    }
}
