using CookBook.Models;
using CookBook.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Core;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YoutubeExplode.Videos.Streams;
using YoutubeExplode;

namespace CookBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VedioPlayingView : ContentPage
    {
        public string URL { get; set; }
        public VedioPlayingView(Users selection)
        {
            InitializeComponent();
            URL = selection.VedioUrl;
            GetVideoContent();
        }
        private async void GetVideoContent()
        {
            YoutubeClient youtube = new YoutubeClient();
            // You can specify video ID or URL
            YoutubeExplode.Videos.Video video = await youtube.Videos.GetAsync(URL);
            string title = video.Title; // "Downloaded Video Title"
                                        //string author = video.Author; // "Downloaded Video Author"
            TimeSpan duration = (TimeSpan)video.Duration; // "Downloaded Video Duration Count"
                                                          //Now it's time to get stream :
            StreamManifest streamManifest = await youtube.Videos.Streams.GetManifestAsync(URL);
            IVideoStreamInfo streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            if (streamInfo != null)
            {
                // Get the actual stream
                System.IO.Stream stream = await youtube.Videos.Streams.GetAsync(streamInfo);
                mediasource.Source = streamInfo.Url;
            }
        }
    }
}