using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{

    [Table(Name = "ba_chapter")]
    [Database(Name = "EZLearnDB")]
    public class BAChapter
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "id", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }

        [Column(Name = "sort_code", ColumnType = DbType.AnsiString)]
        public string SortCode { get; set; }
    }
}
