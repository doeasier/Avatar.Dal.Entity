using System;
using System.Data;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    [Table(Name = "xt_exercises_relation")]
    [Database(Name = "EZLearnDB")]
    public class XTExercisesRelation
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "id", PrimaryKey = true, Identity = true, ColumnType = DbType.Int64)]
        public long? Id { get; set; }

        /// <summary>
        /// 习题Id
        /// </summary>
        [Column(Name = "exercise_id", ColumnType = DbType.AnsiString)]
        public string ExerciseId { get; set; }

        /// <summary>
        /// 关联关系
        /// 1 - 变式题
        /// </summary>
        [Column(Name = "relation_type", ColumnType = DbType.Int32)]
        public int? RelationType { get; set; }

        /// <summary>
        /// 关系Id
        /// </summary>
        [Column(Name = "relation_id", ColumnType = DbType.AnsiString)]
        public string RelationId { get; set; }

        /// <summary>
        /// 关系Id
        /// </summary>
        [Column(Name = "employee_id", ColumnType = DbType.AnsiString)]
        public string EmployeeId { get; set; }
    }
}
