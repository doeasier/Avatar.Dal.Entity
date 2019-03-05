using System.Data;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    [Table(Name = "eas_studentclass")]
    [Database(Name = "EZLearnDB")]
    public class EasStudentClass
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "id", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }

        /// <summary>
        /// 班级
        /// </summary>
        [Column(Name = "classbase_id", ColumnType = DbType.AnsiString)]
        public string ClassBaseId { get; set; }

        /// <summary>
        /// 学生Id
        /// </summary>
        [Column(Name = "studentbase_id", ColumnType = DbType.AnsiString)]
        public string StudentBaseId { get; set; }

        /// <summary>
        /// 是否是当前的班级
        /// </summary>
        [Column(Name = "iscurrent", ColumnType = DbType.Int32)]
        public int? IsCurrent { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        [Column(Name = "enabled", ColumnType = DbType.Int32)]
        public int? Enabled { get; set; }
    }
}
