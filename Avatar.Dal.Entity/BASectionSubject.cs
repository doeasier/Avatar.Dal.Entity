using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{

    [Table(Name = "ba_section_subject")]
    [Database(Name = "EZLearnDB")]
    public class BASectionSubject
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "id", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }

        [Column(Name = "section_id", ColumnType = DbType.AnsiString)]
        public string SectionId { get; set; }

        [Column(Name = "subject_id", ColumnType = DbType.AnsiString)]
        public string SubjectId { get; set; }
    }
}
