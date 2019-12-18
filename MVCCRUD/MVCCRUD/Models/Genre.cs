using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCRUD.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
      
        [Display(Name = "电影类型名")]
        public string From { get; set; }
        public virtual ICollection<Movie> Movie { get; set; }
    }
}