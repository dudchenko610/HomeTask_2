using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_2.Models
{
    public enum SomeEnum 
    { 
        Item1, Item2, Item3
    }

    public class MyCrazyModel
    {
        public SomeEnum propertyEnum { get; set; }
        public int propertyInt { get; set; }
    }
}
