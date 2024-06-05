using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prog122_S24_L11_NewWindow_StaticClass_Observable
{
    public class Data
    {
        public static string BusinessName = "Mike's Sandwich Shop";
        // Observable Collection
        public static ObservableCollection<string> names = new ObservableCollection<string>();


        // Static Constructor
        static Data()
        {
            MessageBox.Show("This Just Ran");
            names.Add("Rafael");
            names.Add("Charles");
            names.Add("Toivo");
            names.Add("Will");
        }

        public static void AddNames(string name)
        {
            name.Add(name);
        }


        public static object Business { get; internal set; }
    } // class

} // namespace
