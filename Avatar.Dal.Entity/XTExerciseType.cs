using MySql.Data.MySqlClient.X.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using XFramework.Dal.Orm;

namespace Avatar.Dal.Entity
{
    [Table(Name = "xt_exercises_type")]
    [Database(Name = "EZLearnDB")]
    public class XTExerciseType
    {
        /// <summary>
        /// Id, 主键
        /// </summary>
        [Column(Name = "id", PrimaryKey = true, ColumnType = DbType.AnsiString)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column(Name = "name", ColumnType = DbType.AnsiString)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column(Name = "sort", ColumnType = DbType.Int32)]
        public int? Sort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column(Name = "enabled", ColumnType = DbType.Int32)]
        public int? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column(Name = "category", ColumnType = DbType.Int32)]
        public int? Category { get; set; }
    }
}
