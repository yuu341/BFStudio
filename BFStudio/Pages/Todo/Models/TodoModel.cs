using BFStudio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BFStudio.Pages.Todo.Models
{
    public class TodoModel
    {
        DBManageEntities db = new DBManageEntities();

        public TodoModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            using (var ent = new DBManageEntities())
            {
                TodoList = ent.V_TODOLIST.ToList();
            }
        }

        public List<V_TODOLIST> TodoList
        {
            get;
            set;
        }

        public DBA_TODO Target
        {
            get;
            set;
        }
    }
}