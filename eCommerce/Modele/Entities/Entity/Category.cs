using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Entities.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryLabel { get; set; }
        public bool CategoryActive { get; set; }
    }
}
