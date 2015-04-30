using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BFStudio.Entity
{
    public partial class MST_MENU
    {
        /// <summary>
        /// 子要素が入るかどうか
        /// </summary>
        public bool HasChild
        {
            get
            {
                return ChildMenu != null && ChildMenu.Count > 0;
            }
        }

        public List<MST_MENU> ChildMenu { get; set; }

        public bool IsActive
        {
            get
            {
                return false;
            }
        }
    }
}