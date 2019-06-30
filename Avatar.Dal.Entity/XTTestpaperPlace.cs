using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    [Table(Name = "xt_testpaper_place")]
    [Database(Name = "EZLearnDB")]
    public class XTTestpaperPlace
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Column(Name = "ID", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }

        /// <summary>
        /// 习题Id
        /// </summary>
        [Column(Name = "place_name", ColumnType = DbType.AnsiString)]
        public string Name { get; set; }

        [Column(Name = "sort", ColumnType = DbType.Int32)]
        public int? Sort { get; set; }
    }
}
