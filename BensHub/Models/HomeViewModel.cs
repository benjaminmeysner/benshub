using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BensHub.Models
{
    public class HomeViewModel
    {
        public IEnumerable<VisitorMessage> VisitorMessages { get; set; }

        public VisitorMessage VisitorMessage { get; set; }

        public SiteStatistic SiteStatistics { get; set; }

        public IEnumerable<File> Files { get; set; }
    }
}