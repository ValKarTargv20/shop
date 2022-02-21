using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Models.Files
{
    public class ExistingFilePathViewModel
    {
        public Guid? PhotoId { get; set; }
        public string FilePath { get; set; }
        public Guid? ProductId { get; set; }
    }
}
