using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookAppEFCoreWF.Context.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SecretAnswer { get; set; }

        public ICollection<Note> Notes { get; set; }
    }

}
