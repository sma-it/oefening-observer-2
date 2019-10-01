using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_2
{
    class Politico : NewsPaper 
    {
        public Politico() : base("Politico", new PublishStrategy.PoliticalNewsOnly()) { }
    }
}
