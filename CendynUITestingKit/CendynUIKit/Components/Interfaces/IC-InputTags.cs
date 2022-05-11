using System;
using System.Collections.Generic;
using System.Text;

namespace CendynUIKit.Components.Interfaces
{
	public interface IC_InputTags
	{
		List<string> GetInputs();
		void EnterText();
		bool Remove();
		string GetPlaceholder();
		bool IsRequired();
		bool IsEnabled();
	}
}
