using System;
using System.Collections.Generic;
using System.Text;
using VideoLibrary;
using System.IO;
using System.Threading.Tasks;

namespace ytdrcore
{
    public class Download
    {
        //declare your class attribute
        private string Title;
        private string Paths;
        private string Format;
        private int AudioBitrate;
        //end atibute body
        public Download(string Paths)//class constructor
        {
            this.Paths = Paths;
        }//end class constructor body

        //declare your method
        public void GetVideo(string link)
        {
//            await Task.Run(() =>
//            {
                var Youtube = YouTube.Default;
                var Video = Youtube.GetVideoAsync("https://www.youtube.com/watch?v=kfm5LpRo4-I");
                var Vr = Video.Result;
                Title = Vr.Title;
                var f = Vr.Format;
                Format = Convert.ToString(f);
                AudioBitrate = Vr.AudioBitrate;

                File.WriteAllBytes(Path.Combine(@"c:\new\" , Vr.FullName),Vr.GetBytes());
                
//            });//end async body
        }//end method GETVideo
    }//end class
}//end name space
