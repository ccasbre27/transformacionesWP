using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Transformaciones.Resources;

namespace Transformaciones
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Ellipse_ManipulationDelta(object sender, System.Windows.Input.ManipulationDeltaEventArgs e)
        {
            transform.TranslateX += e.DeltaManipulation.Translation.X;
            transform.TranslateY += e.DeltaManipulation.Translation.Y;

        }


    }
}