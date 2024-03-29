﻿using Bethanys.Hrm.Shared;
using Microsoft.AspNetCore.Components;

namespace Bethanys.Hrm.Client.Components
{
    public partial class EmployeeRow
    {

        private bool showBenefits;

        [Parameter]
        public EmployeeModel Employee { get; set; }


        public void PremiumToggle(bool premiumBenefit)
        {
            Employee.HasPremiumBenefits = premiumBenefit;
        }

    }
}
