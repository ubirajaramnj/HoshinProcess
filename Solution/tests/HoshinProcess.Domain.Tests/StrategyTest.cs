using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace HoshinProcess.Domain.Tests
{
    public class StrategyTest : IDisposable
    {
        private Person _person;
        private Strategy _strategy;
        private LongTermBreakThroughtObjective 
            _longTermBreakThroughtObjective;
        private AnnualPolicyBreakThroughtObjective
            _annualPolicyBreakThroughtObjective;
        private TopLevelImprovment _topLevelImprovment;
        private TargetToImprove _targetToImprove;

        public StrategyTest()
        {
            _person = new Person() {
                Name = "Ubirajara ",
                Position = "Architect"
            };

            _strategy = new Strategy() {
            };

            _longTermBreakThroughtObjective =
                new LongTermBreakThroughtObjective()
                {
                    Name = "First",
                    Description = "First LongTermBreakThroughtObjective",
                    Priority = 1
                };

            _annualPolicyBreakThroughtObjective =
                new AnnualPolicyBreakThroughtObjective()
                {
                    Name = "First",
                    Description = "First AnnualPolicyBreakThroughtObjective",
                    Priority = 1
                };

            _topLevelImprovment = new TopLevelImprovment()
            {
                Name = "First",
                Description = "First TopLevelImprovment",
                Priority = 1
            };

            _targetToImprove = new TargetToImprove()
            {
                Name = "First",
                Description = "First TargetToImprove",
                Priority = 1
            };
        }

        [Fact]
        public void CreateTest()
        {
            Assert.NotNull(_strategy);
        }

        [Fact]
        public void AddOwnersTest()
        {
            Assert.NotNull(_strategy);

            _strategy.Owners.Add(_person);
            Assert.Contains(_person, _strategy.Owners);
            Assert.Equal(1, _strategy.Owners.Count());
        }

        [Fact]
        public void AddLongTermBreakThroughtObjectiveTest()
        {
            Assert.NotNull(_strategy);

            _strategy.LongTermBreakThroughtObjectives
                .Add(_longTermBreakThroughtObjective);
            Assert.Contains(_longTermBreakThroughtObjective, _strategy.LongTermBreakThroughtObjectives);
            Assert.Equal(1, _strategy.LongTermBreakThroughtObjectives.Count());
        }
        
        [Fact]
        public void AddAnnualPolicyBreakThroughtObjectiveTest()
        {
            Assert.NotNull(_strategy);

            _strategy.AnnualPolicyBreakThroughtObjectives
                .Add(_annualPolicyBreakThroughtObjective);
            Assert.Contains(_annualPolicyBreakThroughtObjective, _strategy.AnnualPolicyBreakThroughtObjectives);
            Assert.Equal(1, _strategy.AnnualPolicyBreakThroughtObjectives.Count());
        }

        [Fact]
        public void AddTopLevelImprovmentTest()
        {
            Assert.NotNull(_strategy);

            _strategy.TopLevelImprovments
                .Add(_topLevelImprovment);
            Assert.Contains(_topLevelImprovment, _strategy.TopLevelImprovments);
            Assert.Equal(1, _strategy.TopLevelImprovments.Count());
        }

        [Fact]
        public void AddTargetToImproveTest()
        {
            Assert.NotNull(_strategy);

            _strategy.TargetsToImprove
                .Add(_targetToImprove);
            Assert.Contains(_targetToImprove, _strategy.TargetsToImprove);
            Assert.Equal(1, _strategy.TargetsToImprove.Count());
        }

        public void Dispose()
        {
               
        }
    }
}