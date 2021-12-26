using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TWS.MVVM.View.Components;

namespace TWS.MVVM.View
{
    /// <summary>
    /// Interaction logic for SearchView.xaml
    /// </summary>
    public partial class SearchView : UserControl
    {
        public SearchView()
        {
            InitializeComponent();
        }

        public void ShowTrips(object sender, EventArgs args)
        {
            for (int i = 0; i < 35; i++)
                TripsPlace.Children.Add(new TripCom());
        }
    }
}
