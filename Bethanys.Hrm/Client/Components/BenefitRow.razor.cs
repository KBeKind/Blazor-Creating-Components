using Bethanys.Hrm.Shared;
using Microsoft.AspNetCore.Components;

namespace Bethanys.Hrm.Client.Components
{
	public partial class BenefitRow
	{

		[Parameter]
		public BenefitEmployeeModel Benefit { get; set; }

		// Adjust this to match how you can reference CheckBoxChanged from BenefitSelector
		[Parameter]
		public Action<bool, int> OnCheckBoxChanged { get; set; }

		private void HandleCheckboxChange(ChangeEventArgs e)
		{
			var isSelected = (bool)e.Value;
			OnCheckBoxChanged?.Invoke(isSelected, Benefit.BenefitId);
		}


	}
}
