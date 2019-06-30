using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    [Table(Name = "xt_subject_exercises_type")]
    [Database(Name = "EZLearnDB")]
    public class XTSubjectExerciseType
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "id", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [Column(Name = "ba_subject_id", ColumnType = DbType.AnsiString)]
        public string SubjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column(Name = "xt_exercises_type_id", ColumnType = DbType.AnsiString)]
        public string ExerciseTypeId { get; set; }

        [Column(Name = "enabled", ColumnType = DbType.Int32)]
        public int? Enabled { get; set; }

        [Column(Name = "sort", ColumnType = DbType.Int32)]
        public int? Sort { get; set; }
    }
}
