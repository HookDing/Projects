//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_GP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class mem
    {
        public int mem_id { get; set; }
        public Nullable<int> mem_brand_id { get; set; }
        public int mem_capacity { get; set; }
        public int mem_frenquence { get; set; }
    
        public virtual brands brands { get; set; }
    }
}
