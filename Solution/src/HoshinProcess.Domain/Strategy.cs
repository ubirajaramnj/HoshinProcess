using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoshinProcess.Domain
{
    public class Strategy
    {
        public Strategy()
        {
            Owners = new List<Person>();

            LongTermBreakThroughtObjectives = 
                new List<LongTermBreakThroughtObjective>();

            AnnualPolicyBreakThroughtObjectives =
                new List<AnnualPolicyBreakThroughtObjective>();

            TopLevelImprovments = 
                new List<TopLevelImprovment>();

            TargetsToImprove =
                new List<TargetToImprove>();
        }

        public virtual List<Person> Owners { get; set; }
        public virtual List<LongTermBreakThroughtObjective> LongTermBreakThroughtObjectives { get; set; }
        public virtual List<AnnualPolicyBreakThroughtObjective> AnnualPolicyBreakThroughtObjectives { get; set; }
        public virtual List<TopLevelImprovment> TopLevelImprovments { get; set; }
        public virtual List<TargetToImprove> TargetsToImprove { get; set; }
    }
}
