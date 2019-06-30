using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    [Table(Name = "ba_yearsemester")]
    [Database(Name = "EZLearnDB")]
    public class BAYearSemester
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "id", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }

        [Column(Name = "yearName", ColumnType = DbType.AnsiString)]
        public string YearName { get; set; }

        [Column(Name = "semester", ColumnType = DbType.AnsiString)]
        public int? Semester { get; set; }

        [Column(Name = "enabled", ColumnType = DbType.AnsiString)]
        public int? Enabled { get; set; }
    }
}
