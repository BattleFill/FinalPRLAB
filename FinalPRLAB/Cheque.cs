//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalPRLAB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cheque
    {
        public int ID_Cheque { get; set; }
        public string Adres { get; set; }
        public string Date_ { get; set; }
        public int Account_ID { get; set; }
        public int Donate_ID { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Donate Donate { get; set; }
    }
}
