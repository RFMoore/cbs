using Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Read
{
    public class HealthRiskCreatedProcessor : Infrastructure.Events.IEventProcessor
    {
        readonly IHealthRisks _healthRisks;

        public HealthRiskCreatedProcessor(IHealthRisks healthRisks)
        {
            _healthRisks = healthRisks;
        }

        public void Process(HealthRiskCreated @event)
        {
            var healthRisk = new HealthRisk()
            {
                Id = @event.Id,
                Name = @event.Name
            };
            _healthRisks.Save(healthRisk);
        }
    }
}
