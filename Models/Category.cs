using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Fiorello.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Products{ get; set; }
    }
}
