using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemoApp
{
    class Actor
    {
        public string name { get; set; }
        public decimal totalGross { get; set; }
        public int movieCout { get; set; }
        public decimal avgPerMovie { get; set; }
        public string topMovie { get; set; }
        public decimal topMovieGros { get; set; }
        public override string ToString()
        {
            return "Name: "+ name+(totalGross!=0 ? " Total Gross: "+totalGross : null)+ (movieCout != 0 ? " Movie Count: " + movieCout : null)+ (avgPerMovie != 0 ? " Movie Avg: " + avgPerMovie : null)+ (topMovie != null ? " Movie Top: " + topMovie : null)+ (topMovieGros != 0 ? " Top Movie Gross: " + topMovieGros : null);
        }
    }
}
