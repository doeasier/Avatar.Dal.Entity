using System.Data;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    /// <summary>
    /// 学期班级表
    /// </summary>
    [Table(Name = "eas_schoolgrade")]
    [Database(Name = "EZLearnDB")]
    public class EasSchoolGrade
    {
        [Column(Name = "ID", PrimaryKey =true, ColumnType = DbType.Int32)]
        public string Id { get; set; }

        /// <summary>
        /// 班级
        /// </summary>
        [Column(Name = "bagradeid", ColumnType = DbType.AnsiString)]
        public string BaGradeId { get; set; }
    }
}
