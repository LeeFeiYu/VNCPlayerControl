using LibVLCSharp.Shared;
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

namespace VNCPlayerControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LibVLCSharp.Shared.MediaPlayer _mediaPlayer1;
        LibVLCSharp.Shared.MediaPlayer _mediaPlayer2;
        LibVLCSharp.Shared.MediaPlayer _mediaPlayer3;
        LibVLCSharp.Shared.MediaPlayer _mediaPlayer4;
        LibVLC _libVLC;
        public MainWindow()
        {


            InitializeComponent();
            Core.Initialize();
            _libVLC = new LibVLC();

            vlcMainPlayer1.Loaded += VlcMainPlayer1_Loaded;
            vlcMainPlayer2.Loaded += VlcMainPlayer2_Loaded;
            vlcMainPlayer3.Loaded += VlcMainPlayer3_Loaded;
            vlcMainPlayer4.Loaded += VlcMainPlayer4_Loaded;
            
        }

        private void VlcMainPlayer1_Loaded(object sender, RoutedEventArgs e)
        {

            //throw new NotImplementedException();
            _mediaPlayer1 = new LibVLCSharp.Shared.MediaPlayer(_libVLC);
            vlcMainPlayer1.MediaPlayer = _mediaPlayer1;
            //vlcMainPlayer1.MediaPlayer.Play(new Media(_libVLC, "C:/Users/might/Downloads/가성비 세계 1등;; 포코 X3 NFC 개봉기 [4K].mp4", FromType.FromPath));
        }

        private void VlcMainPlayer2_Loaded(object sender, RoutedEventArgs e)
        {


            //throw new NotImplementedException();
            _mediaPlayer2 = new LibVLCSharp.Shared.MediaPlayer(_libVLC);
            vlcMainPlayer2.MediaPlayer = _mediaPlayer2;
            //_mediaPlayer2.Play(new Media(_libVLC, "C:/Users/might/Downloads/가성비 세계 1등;; 포코 X3 NFC 개봉기 [4K].mp4", FromType.FromPath));
        }

        private void VlcMainPlayer3_Loaded(object sender, RoutedEventArgs e)
        {

            //throw new NotImplementedException();
            _mediaPlayer3 = new LibVLCSharp.Shared.MediaPlayer(_libVLC);
            vlcMainPlayer3.MediaPlayer = _mediaPlayer3;
            //_mediaPlayer3.Play(new Media(_libVLC, "C:/Users/might/Downloads/가성비 세계 1등;; 포코 X3 NFC 개봉기 [4K].mp4", FromType.FromPath));
        }

        private void VlcMainPlayer4_Loaded(object sender, RoutedEventArgs e)
        {

            //throw new NotImplementedException();
            _mediaPlayer4 = new LibVLCSharp.Shared.MediaPlayer(_libVLC);
            vlcMainPlayer4.MediaPlayer = _mediaPlayer4;
            //_mediaPlayer4.Play(new Media(_libVLC, "C:/Users/might/Downloads/가성비 세계 1등;; 포코 X3 NFC 개봉기 [4K].mp4", FromType.FromPath));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _mediaPlayer1.Play(new Media(_libVLC, new Uri("http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4")));
            _mediaPlayer2.Play(new Media(_libVLC, new Uri("http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4")));
            _mediaPlayer3.Play(new Media(_libVLC, new Uri("http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4")));
            _mediaPlayer4.Play(new Media(_libVLC, new Uri("http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4")));
        }
    }
}
