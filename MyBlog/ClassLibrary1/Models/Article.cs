using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Txt { get; set; }
        public string Img { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DateArticle { get; set; }
    //    {
    //        get
    //        {
    //            return DateArticle;
    //        }
    //set
    //        {
    //            DateArticle = DateTime.Now;
    //        }
    //    }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
