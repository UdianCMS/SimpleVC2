﻿using SGLibrary.Framework.ORM;
using System;

namespace Telossoft.SimpleVC.Model
{
    /// <summary>
    ///教师
    /// </summary>
    [OrmEntity(TableName = "TTeacher",
        FieldDefaultPrefix = "F")]
    public class EnTeacher : IBaseEntity
    {
        [OrmPK]
        public Int64 ID { get; set; }

        [OrmValue(Size=50)]
        public String Name { get; set; }

        public EnTeacher Clone()
        {
            return this.MemberwiseClone() as EnTeacher;
        }
    }
}
