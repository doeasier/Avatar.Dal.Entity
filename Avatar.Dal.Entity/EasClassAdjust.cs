using System.Data;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    /// <summary>
    /// 学期班级表
    /// </summary>
    [Table(Name = "eas_classadjust")]
    [Database(Name = "EZLearnDB")]
    public class EasClassAdjust
    {
        [Column(Name = "iscurrent", ColumnType = DbType.Int32)]
        public int? IsCurrent { get; set; }

        /// <summary>
        /// 班级
        /// </summary>
        [Column(Name = "class_baseid", ColumnType = DbType.AnsiString)]
        public string ClassBaseId { get; set; }

        /// <summary>
        /// 班级名称
        /// </summary>
        [Column(Name = "classname", ColumnType = DbType.AnsiString)]
        public string ClassName { get; set; }

        /// <summary>
        /// 年级Id
        /// </summary>
        [Column(Name = "gradeid", ColumnType = DbType.AnsiString)]
        public string GradeId { get; set; }
    }
}
