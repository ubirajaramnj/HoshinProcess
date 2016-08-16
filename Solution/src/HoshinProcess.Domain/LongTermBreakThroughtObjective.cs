using System;
using System.Collections.Generic;
using System.Linq;

namespace HoshinProcess.Domain
{
    public class LongTermBreakThroughtObjective
    {
        private List<AnnualPolicyBreakThroughtObjective> _annualPolicyBreakThroughtObjective;

        public LongTermBreakThroughtObjective()
        {
            _annualPolicyBreakThroughtObjective = new List<AnnualPolicyBreakThroughtObjective>();
        }

        public Guid Id { get; set; }
        public int Priority { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<AnnualPolicyBreakThroughtObjective> AnnualPolicyBreakThroughtObjective
        {
            get
            {
                return _annualPolicyBreakThroughtObjective
                    .OrderBy(x => x.Priority).ToList();
            }
            set { _annualPolicyBreakThroughtObjective = value; }
        }
    }
}