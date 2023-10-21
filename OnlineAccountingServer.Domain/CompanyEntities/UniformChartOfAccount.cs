using OnlineAccountingServer.Domain.Abstraction;

namespace OnlineAccountingServer.Domain.CompanyEntities
{
    public sealed class UniformChartOfAccount : Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string CompanyId { get; set; }
    }
}
