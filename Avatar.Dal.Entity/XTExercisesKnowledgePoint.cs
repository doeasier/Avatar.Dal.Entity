using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    [Table(Name = "xt_exercises_knowledge_points")]
    [Database(Name = "EZLearnDB")]
    public class XTExercisesKnowledgePoint
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "id", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }

        [Column(Name = "xt_exercises_id", ColumnType = DbType.AnsiString)]
        public string ExercisesId { get; set; }

        [Column(Name = "xt_chapter_id", ColumnType = DbType.AnsiString)]
        public string ChapterId { get; set; }
    }
}
