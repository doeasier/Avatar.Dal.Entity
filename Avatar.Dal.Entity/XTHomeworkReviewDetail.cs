using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    // 批阅明细
    [Table(Name = "xt_homework_review_detail")]
    [Database(Name = "EZLearnDB")]
    public class XTHomeworkReviewDetail
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

        /// <summary>
        /// 员工编号
        /// </summary>
        [Column(Name = "xt_exercises_id", ColumnType = DbType.AnsiString)]
        public string ExerciseId { get; set; }


        /// <summary>
        /// 小题目号码
        /// </summary>
        [Column(Name = "answercode", ColumnType = DbType.Int32)]
        public int? AnswerCode { get; set; }

        /// <summary>
        /// 分数
        /// </summary>
        [Column(Name = "score", ColumnType = DbType.Decimal)]
        public decimal? Score { get; set; }
    }
}
