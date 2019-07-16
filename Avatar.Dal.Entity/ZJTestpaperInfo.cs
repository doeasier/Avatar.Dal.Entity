/*===========================================
 * 类名:ZJTestpaperInfo
 * 作者:Jaine.ch
 * 日期:2019/7/16
 * 作用:组卷生成的试卷表
 * ==========================================*/
using System.Data;
using XFramework.Dal.Orm;


namespace Avatar.Dal.Entity
{
    /// <summary>
    /// 组卷生成的试卷表
    /// 作者:Jaine.ch
    /// 日期:2019/7/16
    /// </summary>
    [Table(Name = "zj_testpaper_info")]
    [Database(Name = "EZLearnDB")]
    public class ZJTestpaperInfo
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "ID", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }
        /// <summary>
        /// 试卷标题
        /// </summary>
        [Column(Name = "Title",  ColumnType = DbType.AnsiString)]
        public string Title { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column(Name = "UserId",  ColumnType = DbType.AnsiString)]
        public string UserId { get; set; }
        /// <summary>
        /// 年段Id
        /// </summary>
        [Column(Name = "SectionId",  ColumnType = DbType.Int32)]
        public int SectionId { get; set; }
        /// <summary>
        /// 学科Id
        /// </summary>
        [Column(Name = "SubjectId",  ColumnType = DbType.Int32)]
        public int SubjectId { get; set; }
        /// <summary>
        /// 文件Id
        /// </summary>
        [Column(Name = "FileId",  ColumnType = DbType.AnsiString)]
        public string FileId { get; set; }
        /// <summary>
        /// 省Id
        /// </summary>
        [Column(Name = "ProvinceId", ColumnType = DbType.Int32)]
        public int ProvinceId { get; set; }
        /// <summary>
        /// 市Id
        /// </summary>
        [Column(Name = "CityId", ColumnType = DbType.Int32)]
        public int CityId { get; set; }
        /// <summary>
        /// 下载次数
        /// </summary>
        [Column(Name = "DownloadCount", ColumnType = DbType.Int32)]
        public int DownloadCount { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(Name = "Create_Date",  ColumnType = DbType.AnsiString)]
        public string Create_Date { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        [Column(Name = "Modify_Date",  ColumnType = DbType.AnsiString)]
        public string Modify_Date { get; set; }
    }
}
