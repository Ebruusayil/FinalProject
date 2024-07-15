using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    // Çıplak clas kalmasın
    public class Category:IEntity
    {
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
    }
}
