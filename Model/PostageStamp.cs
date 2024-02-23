using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrapbook.Model
{
    class PostageStamp
    {
        private int Id {  get; set; }
        public string Name { get; set; }
        public DateTime IssueDate { get; set; }
        public Country Country { get; set; }
        public StampTopic StampTopic { get; set; }
        public string Description { get; set; }
    }
}
