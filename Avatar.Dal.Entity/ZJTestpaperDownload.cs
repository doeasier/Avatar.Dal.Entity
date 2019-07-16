/*===========================================
 * 类名:ZJTestpaperDownload
 * 作者:Jaine.ch
 * 日期:2019/7/16
 * 作用:试卷下载记录表
 * ==========================================*/
using System;
using System.Data;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    /// <summary>
    /// 试卷下载记录表
    /// 作者:Jaine.ch
    /// 日期:2019/7/16
    /// </summary>
    [Table(Name = "zj_testpaper_download")]
    [Database(Name = "EZLearnDB")]
    public class ZJTestpaperDownload
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "ID", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }

        /// <summary>
        /// 试卷Id
        /// </summary>
        [Column(Name = "Testpaper_Id",  ColumnType = DbType.AnsiString)]
        public string Testpaper_Id { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [Column(Name = "UserId", ColumnType = DbType.AnsiString)]
        public string UserId { get; set; }
    }
}
