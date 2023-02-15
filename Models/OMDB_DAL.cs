using Newtonsoft.Json;
using System.Net;

namespace Searching_OMDB_Lab.Models
{
    public class OMDB_DAL
    {
        public static OMDB_Model SearchMovie(string title)
        {
            //setup
            string key = Secret.apiKey;
            string url = $"http://www.omdbapi.com/?apikey={key}&t={title}";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse(); //casting

            //convert to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //c#
            OMDB_Model result = JsonConvert.DeserializeObject<OMDB_Model>(JSON);
            return result;



        }
        //public static OMDB_Model NightMovie(string title1, string title2, string title3)
        //{
        //    //setup
        //    string key = "855b96ef";
        //    string url = $"http://www.omdbapi.com/?apikey={key}&t={title1}";
        //    string url = $"http://www.omdbapi.com/?apikey={key}&t={title2}";
        //    string url = $"http://www.omdbapi.com/?apikey={key}&t={title3}";

        //    //request
        //    HttpWebRequest request = WebRequest.CreateHttp(url);
        //    HttpWebResponse response = (HttpWebResponse)request.GetResponse(); //casting

        //    //convert to JSON
        //    StreamReader reader = new StreamReader(response.GetResponseStream());
        //    string JSON = reader.ReadToEnd();

        //    //c#
        //    OMDB_Model result = JsonConvert.DeserializeObject<OMDB_Model>(JSON);
        //    return result;
        //}
    }
}
