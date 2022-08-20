using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpNunit.JSON.DeserializeJSONResponse
{
    public class APIDetailsResponse
    {
        public List<PhotosRovers> photos { get; set; }
        public class PhotosRovers : RoverDetails
        {
            public int id { get; set; }
            public int sol { get; set; }
           


        }

        public List<CameraDetail> camera { get; set; }
        public class CameraDetail
        {
            public int id { get; set; }
            public string name { get; set; }
            public string rover_id { get; set; }
            public int full_name { get; set; }
            public string img_src { get; set; }
            public string earth_date { get; set; }

        }

        public List<RoverDetails> rover {get; set;}
        public class RoverDetails
        {
            public int id {get; set;}
            public string name {get; set;}
            public string landing_date {get; set;}
            public string launch_date {get; set;}
            public string status {get; set;}

        }



    }
}
