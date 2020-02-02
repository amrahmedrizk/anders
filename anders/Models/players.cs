using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace anders.Models
{
    public class players : IComparable<players>
    {
        public int id { get; set; }
        public string name { get; set; }
        public int score { get; set; }

        public int CompareTo(players x)
        {
            //return this.score.CompareTo(x.score);
            if (this.score < x.score)
            {
                return 1;

            }
            else if (this.score > x.score)
            {
                return -1;
            }
            else
                return 0;
        }
    }
}