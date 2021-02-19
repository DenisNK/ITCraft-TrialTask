using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITCraft_TrialTask.IRepository;

namespace ITCraft_TrialTask.Models
{
    public class User: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
