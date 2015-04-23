using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BFStudio.Entity
{
    [MetadataType(typeof(V_TODOLISTMetadata))]
    public partial class V_TODOLIST
    {
    }

    public class V_TODOLISTMetadata
    {

        [Display(Name = "状態")]
        public string STAGE { get; set; }

        [Display(Name = "タイトル")]
        public string TITLE { get; set; }
    }
}