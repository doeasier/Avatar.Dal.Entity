/*===========================================
 * 类名:ZJTestpaperDetail
 * 作者:Jaine.ch
 * 日期:2019/7/16
 * 作用:组卷生成的试卷表
 * ==========================================*/
using System;
using System.Data;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    /// <summary>
    /// 组卷生成的试卷表
    /// 作者:Jaine.ch
    /// 日期:2019/7/16
    /// </summary>
    [Table(Name = "zj_current_exercise")]
    [Database(Name = "EZLearnDB")]
    public class ZJTestpaperDetail
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "ID", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }
        /// <summary>
        /// 试卷Id
        /// </summary>
        [Column(Name = "Testpaper_Id", ColumnType = DbType.AnsiString)]
        public string Testpaper_Id { get; set; }
        /// <summary>
        /// 习题Id
        /// </summary>
        [Column(Name = "ExerciseId", ColumnType = DbType.AnsiString)]
        public string ExerciseId { get; set; }
        /// <summary>
        /// 显示顺序
        /// </summary>
        [Column(Name = "Sequence", ColumnType = DbType.Int32)]
        public int Sequence { get; set; }

    }
}
