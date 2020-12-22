using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Advanced.Models;
using Microsoft.AspNetCore.Components;

namespace Advanced.Blazor
{
    public partial class Split
    {
        [Inject]
        public DataContext dataContext { get; set; }
        public IEnumerable<string> Names => dataContext.People.Select(p=>p.Firstname);
    }
}
