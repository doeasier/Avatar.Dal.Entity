using System.Data;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    [Table(Name = "v_teach_student")]
    [Database(Name = "EZLearnDB")]
    public class TeachStudentView
    {
        /// <summary>
        /// 年级名称
        /// </summary>
        [Column(Name = "student_id", ColumnType = DbType.AnsiString)]
        public string StudentId { get; set; }

        /// <summary>
        /// 班级ID
        /// </summary>
        [Column(Name = "class_id", ColumnType = DbType.AnsiString)]
        public string ClassId { get; set; }
    }
}
