using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    // 批阅明细
    [Table(Name = "xt_homework_student_answer")]
    [Database(Name = "EZLearnDB")]
    public class XTHomeworkStudentAnswer
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "id", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }

        /// <summary>
        /// 作业Id
        /// </summary>
        [Column(Name = "xt_homework_id", ColumnType = DbType.AnsiString)]
        public string HomeworkId { get; set; }
    }
}
