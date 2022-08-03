using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        public bool IsNew { get; private set; }
        public bool HasChanged { get; set; }
        public EntityStateOption EntityState { get; set; }
        public bool IsValid => Validate();
        public abstract bool Validate();
       

    }
}
