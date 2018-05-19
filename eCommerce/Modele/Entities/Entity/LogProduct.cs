using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Entities.Entity
{
    public class LogProduct
    {
        public int LogId { get; set; }
        public string LogMessage{ get; set; }
        public DateTime LogDate{ get; set; }
        public Products LogProductEntity{ get; set; }
        public int LogProductEntityId { get; set; }
    }
}
