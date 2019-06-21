using System.Data;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    [Table(Name = "xt_homework_student_exercises")]
    [Database(Name = "EZLearnDB")]
    public class XTHomeworkStudentExercise
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
        /// 习题Id
        /// </summary>
        [Column(Name = "xt_exercises_id", ColumnType = DbType.AnsiString)]
        public string ExercisesId { get; set; }

        /// <summary>
        /// 答案类型（1-优秀，2-典型）
        /// </summary>
        [Column(Name = "answer_flag", ColumnType = DbType.Int32)]
        public int? AnswerFlag { get; set; }

        /// <summary>
        /// 答案的图片地址
        /// </summary>
        [Column(Name = "answer_img", ColumnType = DbType.AnsiString)]
        public string AnswerImage { get; set; }
    }
}
