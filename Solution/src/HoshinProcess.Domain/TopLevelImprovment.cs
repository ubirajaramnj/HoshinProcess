using System;
using System.Collections.Generic;
using System.Linq;

namespace HoshinProcess.Domain
{
    public class TopLevelImprovment
    {
        private List<AnnualPolicyBreakThroughtObjective> _annualPolicyBreakThroughtObjective;
        private List<TargetToImprove> _targetsToImprove;

        public TopLevelImprovment()
        {
            _annualPolicyBreakThroughtObjective = new List<AnnualPolicyBreakThroughtObjective>();
            _targetsToImprove = new List<TargetToImprove>();
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

        public virtual List<TargetToImprove> TargetsToImprove
        {
            get
            {
                return _targetsToImprove
                    .OrderBy(x => x.Priority).ToList();
            }
            set { _targetsToImprove = value; }
        }
    }
}