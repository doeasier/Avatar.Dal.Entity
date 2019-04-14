using System.Data;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    [Table(Name = "xt_exercises")]
    [Database(Name = "EZLearnDB")]
    public class XTExercise
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "id", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }

        /// <summary>
        /// 员工编号
        /// </summary>
        [Column(Name = "employee_id", ColumnType = DbType.AnsiString)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 员工编号
        /// </summary>
        [Column(Name = "exercises_parent", ColumnType = DbType.AnsiString)]
        public string ExerciseParent { get; set; }

        /// <summary>
        /// 是否是变式题
        /// </summary>
        [Column(Name = "is_change", ColumnType = DbType.Int32)]
        public int? IsChange { get; set; }
    }
}
