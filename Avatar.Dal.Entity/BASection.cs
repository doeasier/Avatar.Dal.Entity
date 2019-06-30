using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{

    [Table(Name = "ba_section")]
    [Database(Name = "EZLearnDB")]
    public class BASection
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "id", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }

        [Column(Name = "sort_code", ColumnType = DbType.Int32)]
        public int? SortCode { get; set; }

        [Column(Name = "section_name", ColumnType = DbType.AnsiString)]
        public string SectionName { get; set; }

        [Column(Name = "enabled", ColumnType = DbType.Int32)]
        public int? Enabled { get; set; }
    }
}
