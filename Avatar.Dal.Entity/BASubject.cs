using System;
using System.Data;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    [Table(Name = "ba_subject")]
    [Database(Name = "EZLearnDB")]
    public class BASubject
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Column(Name = "ID", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string ID { get; set; }

        /// <summary>
        /// 年级名称
        /// </summary>
        [Column(Name = "Name", ColumnType = DbType.AnsiString)]
        public string Name { get; set; }

        /// <summary>
        /// 排序值
        /// </summary>
        [Column(Name = "Sort", ColumnType = DbType.Int32)]
        public int? Sort { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [Column(Name = "Enabled", ColumnType = DbType.Int32)]
        public int? Enabled { get; set; }
    }
}
