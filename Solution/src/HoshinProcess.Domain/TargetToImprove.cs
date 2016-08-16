using System;
using System.Collections.Generic;
using System.Linq;

namespace HoshinProcess.Domain
{
    public class TargetToImprove
    {
        private List<TopLevelImprovment> _topLevelImprovments;

        public TargetToImprove()
        {
            _topLevelImprovments = new List<TopLevelImprovment>();
        }

        public Guid Id { get; set; }
        public int Priority { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

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