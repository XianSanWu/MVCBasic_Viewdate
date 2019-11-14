using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBasic_Viewdate.Models;

namespace MVCBasic_Viewdate.ViewModels
{
    public class PeopleViewModel
    {
        public List<Employee> employees { get; set; }
        public List<Friend> friends { get; set; }
    }
}