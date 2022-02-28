using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace XBOXGames.Games
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GTA5 : Page
    {
        public GTA5()
        {
            this.InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null && this.Frame.CanGoBack) this.Frame.GoBack();
        }

        private void playvideo_Click(object sender, RoutedEventArgs e)
        {
            previewvideo.Play();
        }

        private void pausevideo_Click(object sender, RoutedEventArgs e)
        {
            previewvideo.Pause();
        }
    }
}
