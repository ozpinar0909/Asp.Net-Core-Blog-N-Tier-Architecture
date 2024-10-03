using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Blog
    {
        [Key]
        public int BlogID{ get; set; }
        public string BlogTitle{ get; set; }
        public string Content{ get; set; }
        public string ThumbnailImage { get; set; }
        public string Image { get; set; }
        public string CreateDate {  get; set; }
        public bool CategoryStatus {  get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comment { get; set; }


    }
}
