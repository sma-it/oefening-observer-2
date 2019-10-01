using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_2
{
    class StandaardPaper : NewsPaper
    {
        public StandaardPaper() : base("Standaard", new PublishStrategy.NoTechNews()) { }
    }
}
