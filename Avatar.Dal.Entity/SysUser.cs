using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{

    [Table(Name = "sys_user")]
    [Database(Name = "EZLearnDB")]
    public class SysUser
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "id", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }

        [Column(Name = "Passwords", ColumnType = DbType.AnsiString)]
        public string Password { get; set; }

        [Column(Name = "EmployeeId", ColumnType = DbType.AnsiString)]
        public string EmployeeId { get; set; }

        [Column(Name = "LoginName", ColumnType = DbType.AnsiString)]
        public string LoginName { get; set; }

        [Column(Name = "UserType", ColumnType = DbType.Int32)]
        public int? UserType { get; set; }
    }
}
