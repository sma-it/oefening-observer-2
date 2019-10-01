using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_2.PublishStrategy
{
    class PoliticalNewsOnly : IFilter
    {
        public bool ShouldPublish(NewsTypes type)
        {
            return type == NewsTypes.Political;
        }
    }
}
