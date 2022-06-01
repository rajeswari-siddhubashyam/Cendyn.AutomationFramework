using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CTOS.Components
{
	public interface IInput
	{
		void EnterInput(string inputText);
		string GetInputText();
		Label GetInputLabel();
		bool IsInputEnabled();
	}
}
