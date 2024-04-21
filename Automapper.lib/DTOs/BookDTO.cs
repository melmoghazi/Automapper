using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automapper.lib.DTOs
{
    //DTOs = View Models = from and to APIs  = from and to razor view
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string AuthorName { get; set; }
        public decimal Price { get; set; }
        
        //public bool IsFree => Price == 0;
        public bool IsFree { get; set; }    
    }
}
