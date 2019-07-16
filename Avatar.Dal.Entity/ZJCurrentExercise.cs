/*===========================================
 * 类名:ZJCurrentExercise
 * 作者:Jaine.ch
 * 日期:2019/7/16
 * 作用:组卷时的题库篮
 * ==========================================*/

using System.Data;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    /// <summary>
    /// 组卷时的题库篮
    /// 作者:Jaine.ch
    /// 日期:2019/7/16
    /// </summary>
    [Table(Name = "zj_current_exercise")]
    [Database(Name = "EZLearnDB")]
    public class ZJCurrentExercise
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "ID", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [Column(Name = "UserId", ColumnType = DbType.AnsiString)]
        public string UserId { get; set; }

        /// <summary>
        /// 年段Id
        /// </summary>
        [Column(Name = "SectionId", ColumnType = DbType.Int32)]
        public int SectionId { get; set; }

        /// <summary>
        /// 学科Id
        /// </summary>
        [Column(Name = "SubjectId", ColumnType = DbType.Int32)]
        public int SubjectId { get; set; }

        /// <summary>
        /// 题目Id
        /// </summary>
        [Column(Name = "ExerciseId", ColumnType = DbType.AnsiString)]
        public string ExerciseId { get; set; }

        /// <summary>
        /// 题形Id
        /// </summary>
        [Column(Name = "ExerciseCategoryId", ColumnType = DbType.Int32)]
        public int ExerciseCategoryId { get; set; }

    }
}
