using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string CompanyName { get; set; }

    }
}
