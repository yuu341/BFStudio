//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BFStudio.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_TICKETLIST
    {
        public long TICKET_ID { get; set; }
        public Nullable<System.DateTime> CREATE_TIME { get; set; }
        public long STATE { get; set; }
        public Nullable<long> TO_USER_ID { get; set; }
        public string TO_USER_NAME { get; set; }
        public string TITLE { get; set; }
    }
}