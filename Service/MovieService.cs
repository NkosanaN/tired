using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MovieApiV.Model;

namespace MovieApiV.Services
{
    public partial class DataHandler
    {
        // public Utils Util { get; set; }
        //public async Task<List<Movie>> MovieListGet()
        //{
        //    var sql = "exec sp_movie_data 0, 1";

        //    var dt = Util.Select(sql);
        //    var list = new List<Movie>();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        list.Add(new Movie
        //        {
        //            Genre = row["Genre"].ToString(),
        //            ReleaseDate = (DateTime)row["ReleaseDate"],
        //            Title = row["Genre"].ToString(),
                    
        //        });
        //    }
        //    return list;
        //}
        //public Movie MovieGetSingle(int Id)
        //{
        //    var sql = $"exec sp_movie_data 1, @id={Id}";

        //    var dt = Util.Select(sql);
        //    if (dt.Rows.Count == 0)
        //    {
        //        return null;
        //    }

        //    DataRow row = dt.Rows[0];
        //    return new Movie
        //    {
        //        Genre = row["Genre"].ToString(),
        //        ReleaseDate = (DateTime)row["ReleaseDate"],
        //        Title = row["Genre"].ToString()
        //    };
        //}

        //public async Task<List<Movie>> GetRatings()
        //{
        //    var sql = "your sql";

        //    var dt = Util.Select(sql);
        //    var list = new List<Movie>();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        list.Add(new Movie
        //        {
        //            Rating = (int)row["Rating"],
        //            checksum = (int)row["checksum"],
                    
        //        });
        //    }
        //    return list;
        //}
        //public bool AddMovie(Movie data)
        //{
        //    var sql = $"exec sp_users_process 0 , @Title='{data.Title}',@Genre = '{data.Genre}'";
        //    return Util.Execute(sql);
        //}
        ////must test this one
        //public bool DeleteMovie(int Id)
        //{
        //    var sql = $"exec sp_movie_data 2 @id={Id}";
        //    return Util.Execute(sql);
        //}

    }
}
