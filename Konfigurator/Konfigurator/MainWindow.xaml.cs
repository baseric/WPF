using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace Konfigurator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListCollectionView view;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbZamowienia.ItemsSource = MyDB.Instance.GetZamowienia();

            view = CollectionViewSource.GetDefaultView(lbZamowienia.ItemsSource) as ListCollectionView;

            view.SortDescriptions.Add(new SortDescription("Date", ListSortDirection.Descending));

            DataGrouper grouper = new DataGrouper();
            view.GroupDescriptions.Add(new PropertyGroupDescription("getData", grouper));
        }

        private void EditCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;

            ListBox lb = e.Parameter as ListBox;

            if (lb == null)
                return;

            if (lb.SelectedIndex < 0)
                e.CanExecute = false;

        }

        private void Edytuj(object sender, ExecutedRoutedEventArgs e)
        {
            ListBox lb = e.Parameter as ListBox;

            Dodaj win = new Dodaj(new Pojazd(((Zamowienie)lb.SelectedItem).Pojazd), new Klient(((Zamowienie)lb.SelectedItem).Klient), 6);

            if ((bool)win.ShowDialog())
            {
                ((Zamowienie)lb.SelectedItem).Pojazd = win.P;
                ((Zamowienie)lb.SelectedItem).Klient = win.K;
            }

            e.Handled = true;
        }

        private void EdytujStatus(object sender, ExecutedRoutedEventArgs e)
        {
            ListBox lb = e.Parameter as ListBox;

            status win = new status((Zamowienie)lb.SelectedItem);

            win.ShowDialog();

            e.Handled = true;
        }

        private void Usun(object sender, ExecutedRoutedEventArgs e)
        {
            ListBox lb = e.Parameter as ListBox;

            if (MessageBox.Show("Czy na pewno chcesz usunąć zamówienie?", "Usuwanie", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MyDB.Instance.RemoveZamowienie((Zamowienie)lb.SelectedItem);
            }
            

            e.Handled = true;
        }

        private void Podglad(object sender, ExecutedRoutedEventArgs e)
        {
            ListBox lb = e.Parameter as ListBox;

            dane win = new dane((Zamowienie)lb.SelectedItem);

            win.ShowDialog();

            e.Handled = true;
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            Dodaj win = new Dodaj(new Pojazd(), new Klient(), 0);

            if ((bool)win.ShowDialog())
            {
                MyDB.Instance.AddZamowienie(win.k, win.p);
            }
        }

        private void FiltrRok(object sender, RoutedEventArgs e)
        {
            int min;
            int max;
            if ((int.TryParse(RokOd.Text, out min)) && (int.TryParse(RokDo.Text, out max)))
            {

                if (view != null)
                {
                    RokFilter filter = new RokFilter(min, max);
                    view.Filter = filter.FilterItem;
                }
            }
        }

        private void FiltrCancel(object sender, RoutedEventArgs e)
        {
            if (view != null)
                view.Filter = null;
        }      
    }
}
