﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookAppEFCoreWF.Context.Entities
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Context { get; set; }
        public DateTime AddedDate { get; set; }

        public int CategoryId { get; set; }
        public int UserId {  get; set; }

        public User User { get; set; }
        public Category? Category { get; set; }

    }
}
