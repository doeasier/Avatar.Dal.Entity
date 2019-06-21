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

        [Column(Name = "chapter_type", ColumnType = DbType.Int32)]
        public int? ChapterType { get; set; }

        [Column(Name = "parent_id", ColumnType = DbType.AnsiString)]
        public string ParentId { get; set; }

        [Column(Name = "material_id", ColumnType = DbType.AnsiString)]
        public string MaterialId { get; set; }

        [Column(Name = "chapter_name", ColumnType = DbType.AnsiString)]
        public string ChapterName { get; set; }

        [Column(Name = "employee_id", ColumnType = DbType.AnsiString)]
        public string EmployeeId { get; set; }
    }
}
