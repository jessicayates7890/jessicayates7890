using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotesApp.Models
{
    public class UserModel
    {
        private NotesAppContext context;
        public int id { get; set; }
        [Required] public string full_name { get; set; }
        [Required] public string email { get; set; }
        [Required] public string username { get; set; }
        [Required] public string password { get; set; }
    }
}
