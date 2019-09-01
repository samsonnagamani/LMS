using System.Collections.Generic;

namespace LMS.Models
{
    public class BranchModel
    {
        public int Id { get; set;  }
        public int total_num_assets { get; set; }
        public float total_val_assets { get; set; }
        
        public ICollection<BookModel> books { get; set; }

    }
}