//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo
{
    using System;
    using System.Collections.Generic;
    
    public partial class user_zakaz
    {
        public int ID { get; set; }
        public int ID_user { get; set; }
        public int ID_zakaz { get; set; }
    
        public virtual Users Users { get; set; }
        public virtual Zakaz Zakaz { get; set; }
    }
}
