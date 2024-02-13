using Bethanys.Components;
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


		public Dictionary<string, object> DateFieldInputAttributes =
			new Dictionary<string, object>
			{
				{"placeholder", "Enter a date"},
				{"required", "required"},
				{"size", "1000" }
			};


		public DateField DateRef { get; set; }

		public async Task RevertDateField()
		{
			await DateRef.Revert();
		}

		private void HandleCheckboxChange(ChangeEventArgs e)
		{
			var isSelected = (bool)e.Value;
			OnCheckBoxChanged?.Invoke(isSelected, Benefit.BenefitId);
		}




	}
}
