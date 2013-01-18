using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Konfigurator
{
    class CustomCommands
    {
        public static RoutedUICommand edytuj;
        public static RoutedUICommand usun;
        public static RoutedUICommand eksport;

        static CustomCommands()
        {
            edytuj = new RoutedUICommand("Zdejmij krążek", "Zdejmij", typeof(CustomCommands));
            usun = new RoutedUICommand("Połóż krążek", "Połóż", typeof(CustomCommands));
            eksport = new RoutedUICommand("Połóż krążek", "Połóż", typeof(CustomCommands));
        }

        public static RoutedUICommand Edytuj
        {
            get { return edytuj; }
        }

        public static RoutedUICommand Usun
        {
            get { return usun; }
        }

        public static RoutedUICommand Eksport
        {
            get { return eksport; }
        }
    }
}
