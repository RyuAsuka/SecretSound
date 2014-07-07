using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecretSound.View
{
    class ViewLeader
    {
        static private DecipheringView DV;
        static private EncipheringView EV;

        static ViewLeader()
        {
            DV = new DecipheringView();
            EV = new EncipheringView();
        }

        static public DecipheringView DecipheringView
        {
            get
            {
                return DV;
            }
        }

        static public EncipheringView EncipheringView
        {
            get
            {
                return EV;
            }
        }
    }
}
