using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectedDemo_36.Models
{
    // Buissness Model Layer : Buissness Entities
    // Plain CLR Object : POCO class
    internal class Emp
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public string EAddress { get; set; }
    }
}