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
        private string SavePath;
        private string Format;
        private string FullName;
        private int AudioBitrate;
        private string audioFormats;
        //end atibute body
        // start Properties body
        public string AudioFormats
        {
            get { return this.audioFormats; }
        }
        public string FullNames{
            get { return this.FullName; }
            }
        public string savePath
        {
            get { return this.SavePath; }
            set { this.SavePath = value; }
        }
        public string Titles
        {
            get { return this.Title; }
        }
        public string Formats
        {
            get { return this.Format; }
        }
        public int AudioBitrates {
            get { return this.AudioBitrate; }
        }
        //end Properties body
        public Download()//class constructor
        {
//parse
        }//end class constructor body

        //declare your method
        public void GetVideo(string link)
        {
            try
            {
                var Youtube = YouTube.Default;
                var Video = Youtube.GetVideoAsync(link);
                var Vr = Video.Result;
                Title = Vr.Title;
                var f = Vr.Format;
                Format = Convert.ToString(f);
                AudioBitrate = Vr.AudioBitrate;
                FullName = Vr.FullName;
                audioFormats = Vr.AudioFormat.ToString();
                File.WriteAllBytes(Path.Combine(@SavePath, Vr.FullName), Vr.GetBytes());
            }//end try body
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }//end catch body
        }//end method GETVideo
    }//end class
}//end name space
