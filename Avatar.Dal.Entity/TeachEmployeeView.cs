using System.Data;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    [Table(Name = "v_teach_employee")]
    [Database(Name = "EZLearnDB")]
    public class TeachEmployeeView
    {
        /// <summary>
        /// 0-行政班、1-教学班
        /// </summary>
        [Column(Name = "class_type", ColumnType = DbType.Int32)]
        public long? ClassType { get; set; }

        /// <summary>
        /// 年级名称
        /// </summary>
        [Column(Name = "grade_class_name", ColumnType = DbType.AnsiString)]
        public string GradeClassName { get; set; }

        /// <summary>
        /// 员工号
        /// </summary>
        [Column(Name = "employee_id", ColumnType = DbType.AnsiString)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 级
        /// </summary>
        [Column(Name = "circle", ColumnType = DbType.Int32)]
        public int? Circle { get; set; }

        /// <summary>
        /// 班级ID
        /// </summary>
        [Column(Name = "class_id", ColumnType = DbType.AnsiString)]
        public string ClassId { get; set; }

        /// <summary>
        /// 学科ID
        /// </summary>
        [Column(Name = "ba_subject_id", ColumnType = DbType.AnsiString)]
        public string SubjectId { get; set; }

        /// <summary>
        /// 学科名称
        /// </summary>
        [Column(Name = "course_name", ColumnType = DbType.AnsiString)]
        public string SubjectName { get; set; }

        /// <summary>
        /// 学校ID
        /// </summary>
        [Column(Name = "school_id", ColumnType = DbType.AnsiString)]
        public string SchoolId { get; set; }
    }
}
