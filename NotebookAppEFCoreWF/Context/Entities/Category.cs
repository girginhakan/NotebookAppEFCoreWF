using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookAppEFCoreWF.Context.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        //public Image Picture { get; set; }

        public ICollection<Note> Notes { get; set; }
    }
}
