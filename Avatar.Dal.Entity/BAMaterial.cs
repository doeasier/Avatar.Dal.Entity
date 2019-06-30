using System;
using System.Data;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    [Table(Name = "ba_material")]
    [Database(Name = "EZLearnDB")]
    public class BAMaterial
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Column(Name = "ID", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }

        /// <summary>
        /// 年级名称
        /// </summary>
        [Column(Name = "BA_Grade_ID", ColumnType = DbType.AnsiString)]
        public string GradeId { get; set; }

        /// <summary>
        /// 学科名称
        /// </summary>
        [Column(Name = "Public_Course_ID", ColumnType = DbType.AnsiString)]
        public string SubjectId { get; set; }

        /// <summary>
        /// 出版社
        /// </summary>
        [Column(Name = "Publisher_Name", ColumnType = DbType.AnsiString)]
        public string PublisherName { get; set; }

        /// <summary>
        /// 教材名称
        /// </summary>
        [Column(Name = "Book_Type", ColumnType = DbType.AnsiString)]
        public string BookType { get; set; }

        /// <summary>
        /// 出版社
        /// </summary>
        [Column(Name = "Sort_Code", ColumnType = DbType.Int32)]
        public int? SortCode { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [Column(Name = "Enabled", ColumnType = DbType.Int32)]
        public int? Enabled { get; set; }

        /// <summary>
        /// 教材名称
        /// </summary>
        [Column(Name = "Section_Id", ColumnType = DbType.AnsiString)]
        public string SectionId { get; set; }
    }
}
