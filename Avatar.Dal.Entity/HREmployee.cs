using System.Data;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    [Table(Name = "hr_employee")]
    [Database(Name = "EZLearnDB")]
    public class HREmployee
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "ID", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }

        [Column(Name = "SchoolID", ColumnType = DbType.AnsiString)]
        public string SchoolId { get; set; }

        [Column(Name = "Name", ColumnType = DbType.AnsiString)]
        public string Name { get; set; }

        [Column(Name = "SubjectIDs", ColumnType = DbType.AnsiString)]
        public string SubjectIds { get; set; }

    }
}
