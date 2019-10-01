using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_2
{
    class TimesPaper : NewsPaper
    {
        public TimesPaper() : base("New York Times", new PublishStrategy.AllNews()) { }
    }
}
