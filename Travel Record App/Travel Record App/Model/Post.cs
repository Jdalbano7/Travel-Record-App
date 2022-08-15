using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Travel_Record_App.Model
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } //Needed for sqlite. Allows us to identify an element from one another.
                                    //int is the default type for sqlite
        [MaxLength (300)]
        public string Experience { get; set; }


    }
}
