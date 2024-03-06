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
using Windows.UI;
using System.Diagnostics;


namespace random_button
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public sealed partial class MainPage : Page
    {
        private Random rand;

        public MainPage()
        {
            this.InitializeComponent();
            rand = new Random();
        }

        public Random Rand { get => rand; set => rand = value; }

        private byte[] GetRandomBytes(int n)
        {
            // Fill an array of bytes of length "n" with random numbers.
            var randomBytes = new byte[n];
            rand.NextBytes(randomBytes);
            return randomBytes;
        }

        private void SayHelloButton_Click(object sender, RoutedEventArgs e)
        {
            byte[] rgb = GetRandomBytes(3);

            // Create a solid color brush using the three random numbers.
            var randomColorBrush = new SolidColorBrush(Color.FromArgb(255, rgb[0], rgb[1], rgb[2]));

            // Set both the text color and the text box border to the random color.
            textBox1.BorderBrush = randomColorBrush;
            textBox1.Foreground = randomColorBrush;
        }
        private void SayHelloButton_ClickQ(object sender, RoutedEventArgs e)
        {
            byte[] rgb = GetRandomBytes(3);

            // Create a solid color brush using the three random numbers.
            var randomColorBrush = new SolidColorBrush(Color.FromArgb(255, 0, 0, rgb[2]));

            // Set both the text color and the text box border to the random color.
            textBox1.BorderBrush = randomColorBrush;
            textBox1.Foreground = randomColorBrush;
        }
        private void SayHelloButton_ClickW(object sender, RoutedEventArgs e)
        {
            byte[] rgb = GetRandomBytes(3);

            // Create a solid color brush using the three random numbers.
            var randomColorBrush = new SolidColorBrush(Color.FromArgb(255, 0, rgb[1], 0));

            // Set both the text color and the text box border to the random color.
            textBox1.BorderBrush = randomColorBrush;
            textBox1.Foreground = randomColorBrush;
        }
        private void SayHelloButton_ClickE(object sender, RoutedEventArgs e)
        {
            byte[] rgb = GetRandomBytes(3);

            // Create a solid color brush using the three random numbers.
            var randomColorBrush = new SolidColorBrush(Color.FromArgb(255, rgb[0], 0, 0));

            // Set both the text color and the text box border to the random color.
            textBox1.BorderBrush = randomColorBrush;
            textBox1.Foreground = randomColorBrush;
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        
    }
}
