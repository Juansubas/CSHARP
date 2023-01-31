using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.Models
{
    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        public string DatosCompletos
        {
            get { return "userId: " + userId + "\nid: " + id + "\ntitle: " + title + "\nbody: " + body; }
        }

        public override string ToString()
        {
            return DatosCompletos;
        }

    }
}
