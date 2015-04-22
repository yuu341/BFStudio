using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BFStudio.Entity
{
    [MetadataType(typeof(DBA_TICKETMetadata))]
    public partial class DBA_TICKET
    {
        public string StateString
        {
            get
            {
                switch (STATE)
                {
                    case 1:
                        return "質問厨";
                    case 2:
                        return "進行中";
                    case 3:
                        return "解決";
                    default:
                        return "";
                }
            }
        }

        [Display( Name= "プロジェクト名")]
        public string ProjectName
        {
            get
            {
                return "未実装";
            }
        }

        [Display ( Name = "区分")]
        public string TicketKbn
        {
            get
            {
                return "未実装";
            }
        }

        [Display( Name= "対応者")]
        public string ToUserName
        {
            get
            {
                return "ユーザ名";
            }
        }
    }

    public class DBA_TICKETMetadata
    {

    }
}