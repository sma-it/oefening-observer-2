using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_2.PublishStrategy
{
    class AllNews : IFilter
    {
        public bool ShouldPublish(NewsTypes type)
        {
            return true;
        }
    }
}
