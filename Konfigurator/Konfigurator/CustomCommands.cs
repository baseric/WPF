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
        public static RoutedUICommand edytujStatus;
        public static RoutedUICommand usun;
        public static RoutedUICommand eksport;
        public static RoutedUICommand dalej;

        static CustomCommands()
        {
            edytuj = new RoutedUICommand("Edytuj zamowienie", "Edytuj", typeof(CustomCommands));
            edytujStatus = new RoutedUICommand("Edytuj status zamówienia", "EdytujStatus", typeof(CustomCommands));
            usun = new RoutedUICommand("Usun zamowienie", "Usun", typeof(CustomCommands));
            eksport = new RoutedUICommand("Eksportuj do pdf", "Eksportuj", typeof(CustomCommands));
            dalej = new RoutedUICommand("Przejdz dalej", "Dalej", typeof(CustomCommands));
        }

        public static RoutedUICommand Edytuj
        {
            get { return edytuj; }
        }

        public static RoutedUICommand EdytujStatus
        {
            get { return edytujStatus; }
        }

        public static RoutedUICommand Usun
        {
            get { return usun; }
        }

        public static RoutedUICommand Eksport
        {
            get { return eksport; }
        }

        public static RoutedUICommand Dalej
        {
            get { return dalej; }
        }
    }
}
