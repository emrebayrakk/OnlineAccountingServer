﻿using OnlineAccountingServer.Domain.Abstraction;

namespace OnlineAccountingServer.Domain.AppEntities
{
    public sealed class Company : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string IdentityNumber { get; set; }
        public string TaxDepartmemt { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
