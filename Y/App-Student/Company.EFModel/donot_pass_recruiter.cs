//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Company.EFModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class donot_pass_recruiter
    {
        public byte donot_pass_recruiter_id { get; set; }
        public byte recruiter_id { get; set; }
        public string reson_donot_pass { get; set; }
        public System.TimeSpan time_of_result { get; set; }
        public Nullable<byte> audit_staff_id { get; set; }
    }
}