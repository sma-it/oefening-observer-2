using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_2.PublishStrategy
{
    interface IFilter
    {
        bool ShouldPublish(NewsTypes type);
    }
}
