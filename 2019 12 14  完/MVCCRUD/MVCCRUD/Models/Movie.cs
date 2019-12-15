using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCRUD.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        //[StringLength(128, ErrorMessage = "电影名最多128字符")]
        //[Required(ErrorMessage = "电影名不能为空")]
        //[Display(Name = "电影名")]
        public string MovieName { get; set; }
        //[Required(ErrorMessage = "上映时间不能为空")]
        //[Display(Name = "上映时间")]
        public string ReleaseTime { get; set; }
        //[Required(ErrorMessage = "地区不能为空")]
        //[Display(Name = "地区")]
        public string District { get; set; }
        //[Required(ErrorMessage = "导演不能为空")]
        //[Display(Name = "导演")]
        public string Director { get; set; }
        //[Required(ErrorMessage = "片长不能为空")]
        //[Display(Name = "片长")]
        public int MyMovieLength { get; set; }
        //[Required(ErrorMessage = "类型不能为空")]
        //[Display(Name = "类型")]
        public int GenreId { get; set; }
        //[Required(ErrorMessage = "价格不能为空")]
        //[Display(Name = "价格")]
        public decimal Price { get; set; }
        public virtual Genre Genre { get; set; }
    }
}