using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCRUD.Models
{
    public class MGDbInitializer:System .Data .Entity .DropCreateDatabaseIfModelChanges <MovieGenreDbContext>
    {
        protected override void Seed(MovieGenreDbContext db)
        {
            db.Genres.Add(new Models.Genre() { From = "科幻" });
            db.Genres.Add(new Models.Genre() { From = "喜剧" });
            db.Genres.Add(new Models.Genre() { From = "动作" });
            db.Genres.Add(new Models.Genre() { From = "武侠" });
            db.Genres.Add(new Models.Genre() { From = "剧情" });
            db.Movies.Add(new Models.Movie()
            {
                //Awards = new List<Awards>()
                //{

                //      db.Awardss.Find (1)
                //},


                MovieName = "明日边缘",
                //上映时间为string类型且格式正确 例子：2019-12-17  即可在视图data显示
                ReleaseTime = "2019-12-17",
                Price = 10,
                Genre = new Genre() { From = "科幻", GenreId = 1 }
            ,
                District = "美国",
                Director = "道格.里曼",
                MyMovieLength = 113,
            });


            //db.Movies.Add(new Models.Movie()
            //{
            //    //Awards = new List<Awards>()
            //    //{

            //    //      db.Awardss.Find (1)
            //    //},
            //    MovieName = "流浪地球",
            //    ReleaseTime = "2019-02-17",
            //    Price = 9,
            //    GenreId = 1,
            //    District = "中国大陆",
            //    Director = "郭帆",
            //    MyMovieLength = 125

            //});
            //db.Movies.Add(new Models.Movie()
            //{
            //    //Awards = new List<Awards>()
            //    //{

            //    //      db.Awardss.Find (2)
            //    //},
            //    MovieName = "人再囧途之泰囧",
            //    ReleaseTime = "2012-12-12",
            //    Price = 10,
            //    GenreId = 2,
            //    District = "中国大陆",
            //    Director = "徐峥",
            //    MyMovieLength = 105

            //});
            //db.Movies.Add(new Models.Movie()
            //{
            //    //    Awards = new List<Awards>()
            //    //    {

            //    //          db.Awardss.Find (3)
            //    //    },
            //    MovieName = "大鱼",
            //    ReleaseTime = "2003-12-10",
            //    Price = 21,
            //    GenreId = 2,
            //    District = "美国",
            //    Director = "蒂姆·波顿",
            //    MyMovieLength = 125

            //});
            //db.Movies.Add(new Models.Movie()
            //{
            //    //Awards = new List<Awards>()
            //    //{

            //    //      db.Awardss.Find (4)
            //    //},
            //    MovieName = "十二生肖",
            //    ReleaseTime = "2013-02-17",
            //    Price = 31,
            //    GenreId = 3,
            //    District = "中国大陆、中国香港",
            //    Director = "成龙",
            //    MyMovieLength = 122

            //});
            //db.Movies.Add(new Models.Movie()
            //{
            //    //Awards = new List<Awards>()
            //    //{

            //    //      db.Awardss.Find (5)
            //    //},
            //    MovieName = "功夫",
            //    ReleaseTime = "2012-01-17",
            //    Price = 34,
            //    GenreId = 3,
            //    District = "中国香港、中国大陆",
            //    Director = "周星驰",
            //    MyMovieLength = 95

            //});
            //db.Movies.Add(new Models.Movie()
            //{
            //    //Awards = new List<Awards>()
            //    //{

            //    //      db.Awardss.Find (2),
            //    //          db.Awardss.Find (1),
            //    //},
            //    MovieName = "笑傲江湖Ⅱ：东方不败",
            //    ReleaseTime = "2003-11-11",
            //    Price = 18,
            //    GenreId = 4,
            //    District = "中国香港",
            //    Director = "程小东",
            //    MyMovieLength = 107

            //});
            //db.Movies.Add(new Models.Movie()
            //{
            //    //Awards = new List<Awards>()
            //    //{

            //    //       db.Awardss.Find (2),
            //    //          db.Awardss.Find (1),
            //    //},
            //    MovieName = "三闯少林",
            //    ReleaseTime = "1983-07-27",
            //    Price = 7,
            //    GenreId = 4,
            //    District = "中国香港",
            //    Director = "唐佳",
            //    MyMovieLength = 86

            //});
            //db.Movies.Add(new Models.Movie()
            //{
            //    MovieName = "末代皇帝",
            //    ReleaseTime = "1992-11-17",
            //    Price = 12,
            //    GenreId = 5,
            //    District = "中国、法国、英国、意大利、日本",
            //    Director = "贝纳尔多·贝托鲁奇",
            //    MyMovieLength = 163

            //});
            //db.Movies.Add(new Models.Movie()
            //{
            //    //Awards = new List<Awards>()
            //    //{

            //    //  db.Awardss.Find (2),
            //    //          db.Awardss.Find (1),
            //    //},
            //    MovieName = "霸王别姬",
            //    ReleaseTime = "1995-10-05",
            //    Price = 22,
            //    GenreId = 5,
            //    District = "中国大陆，中国香港",
            //    Director = "陈凯歌",
            //    MyMovieLength = 171

            //});
            base.Seed(db);
        }
        }
    }
      

