using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS
{
    class Util
    {
        public static bool isChecked(int state)
        {
            if (state == 0)
                return false;
            else
                return true;
            

        }



        public static int BoolToInt ( bool state)
        {
            if (state)
                return 1;
            else
                return 0;

        }
         
        
        public static float isFloat(string number)
        {
            float f=0;

            if (float.TryParse(number, out f))
            {

                return f;

            }
            else
            {
                return 0;
            }


        }
       

    }
}
