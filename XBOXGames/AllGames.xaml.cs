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

namespace XBOXGames
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AllGames : Page
    {
        public AllGames()
        {
            this.InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null && this.Frame.CanGoBack) this.Frame.GoBack();
        }

        //Games

        private void fifa20_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.FIFA20));
        }

        private void nba19_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.NBA2K19));
        }

        private void needforspeed2019_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.NeedForSpeed2019));
        }

        private void fifa19_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.FIFA19));
        }

        private void needforspeedtherun_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.NeedForSpeedTheRun));
        }

        private void ragingthunder2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.RagingThunder2));
        }

        private void needforspeedpayback_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.NeedForSpeedPayback));
        }

        private void callofdutyinfinitewarfare_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.CallOfDutyInfiniteWarfare));
        }

        private void fifa18_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.FIFA18));
        }

        private void gta5_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.GTA5));
        }

        private void ragingthunder_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.RagingThunder));
        }

        private void gtasa_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.GTASanAndreas));
        }

        private void callofdutyblackops_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.CallOfDutyBlackOps));
        }

        private void candycrushjelly_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.CandyCrushJelly));
        }

        private void nba18_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.NBA2K18));
        }

        private void candycrushsoda_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.CandyCrushSoda));
        }

        private void chessultra_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.ChessUltra));
        }

        private void spidersolitaire_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.SpiderSolitaire));
        }

        private void templerun_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.TempleRun));
        }

        private void subwaysurfers_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.SubwaySurfers));
        }

        private void pes18_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.PES18));
        }

        private void asphalt9legends_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.Asphalt9Legends));
        }

        private void _8ballpool_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games._8BallPool));
        }

        private void dreamleaguesoccer2019_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.DreamLeagueSoccer2019));
        }

        private void episode_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.Episode));
        }

        private void angrybirds2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.AngryBirds2));
        }

        private void matatu_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.Matatu));
        }

        private void csrracing2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.CSRRacing2));
        }

        private void gtavicecity_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.GTAViceCity));
        }

        private void needforspeedmostwanted_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.NeedForSpeedMostWanted));
        }

        private void csrracing_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.CSRRacing));
        }

        private void scrabble_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.Scrabble));
        }

        private void asphalt8airborne_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.Asphalt8Airborne));
        }

        private void fruitninja_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.FruitNinja));
        }

        private void minecraft_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games.MineCraft));
        }

    }
}
