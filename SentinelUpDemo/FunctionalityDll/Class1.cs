using System;
using System.Windows;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalityDll
{
    public class Class1
    {
        public static string version = "v2";

        public string SayHi()
        {
            return "Hi Men!";
        }

        public string SayBay()
        {
            return "Bay Men!";
        }

        public bool EnableButton()
        {
            if (version == "v2") {
                return true;
            } else if (version == "v1") {
                return false;
            } else {
                return false;
            }
        }
    }
}
