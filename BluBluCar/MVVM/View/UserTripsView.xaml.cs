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
    /// Interaction logic for UserTripsView.xaml
    /// </summary>
    public partial class UserTripsView : UserControl
    {
        public UserTripsView()
        {
            InitializeComponent();
            ShowCompletedTrips();
            ShowPlannedTrips();
        }

        private void ShowCompletedTrips()
        {
            for (int i = 0; i < 5; i++)
                CompletedTrips.Children.Add(new CompletedTrip());
        }

        private void ShowPlannedTrips()
        {
            for (int i = 0; i < 3; i++)
                PlannedTrips.Children.Add(new TripCom());
        }

    }
}
