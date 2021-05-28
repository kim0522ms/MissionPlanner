using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPRemoteCommandTestApp.DTO
{
    public static class Waypoint
    {
        public static JObject ToJObject(string id, string p1, string p2, string p3, string p4, string lat, string lng, string alt, string seq, string frame)
        {
            JObject jobj = new JObject();
            jobj.Add("id", id);
            jobj.Add("p1", p1);
            jobj.Add("p2", p2);
            jobj.Add("p3", p3);
            jobj.Add("p4", p4);
            jobj.Add("lat", lat);
            jobj.Add("lng", lng);
            jobj.Add("alt", alt);
            jobj.Add("seq", seq);
            jobj.Add("frame", frame);

            return jobj;
        }
    }
}
