using Scrapbook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrapbook.ViewModel
{
    class MainWindowViewModel
    {
        public List<PostageStamp> PostageStamps { get; private set; } = new List<PostageStamp>();
        public MainWindowViewModel() 
        {
            
        }
    }
}
