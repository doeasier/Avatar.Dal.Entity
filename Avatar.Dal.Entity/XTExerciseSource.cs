using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{

    [Table(Name = "xt_exercises_source")]
    [Database(Name = "EZLearnDB")]
    public class XTExerciseSource
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "id", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column(Name = "name", ColumnType = DbType.AnsiString)]
        public string Name { get; set; }
    }
}
