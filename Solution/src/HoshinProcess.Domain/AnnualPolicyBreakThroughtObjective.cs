using System;
using System.Collections.Generic;
using System.Linq;

namespace HoshinProcess.Domain
{
    public class AnnualPolicyBreakThroughtObjective
    {
        private List<LongTermBreakThroughtObjective> 
            _longTermBreakThroughtObjectives;

        private List<TopLevelImprovment>
            _topLevelImprovments;

        public AnnualPolicyBreakThroughtObjective()
        {
            _longTermBreakThroughtObjectives = 
                new List<LongTermBreakThroughtObjective>();

            _topLevelImprovments = new List<TopLevelImprovment>();
        }

        public Guid Id { get; set; }
        public int Priority { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<LongTermBreakThroughtObjective> LongTermBreakThroughtObjectives
        {
            get
            {
                return _longTermBreakThroughtObjectives
                    .OrderBy(x => x.Priority).ToList();
            }
            set
            {
                _longTermBreakThroughtObjectives = value;
            }
        }

        public List<TopLevelImprovment> TopLevelImprovments
        {
            get
            {
                return _topLevelImprovments
                    .OrderBy(x => x.Priority).ToList();
            }
            set
            {
                _topLevelImprovments = value;
            }
        }

    }
}