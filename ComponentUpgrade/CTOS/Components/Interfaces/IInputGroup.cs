using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CTOS.Components
{
	public interface IInputGroup
	{
		//void EnterInput();
		//void GetEnteredInput();
		//Label GetInputLabel();
		//bool IsEnabled();
		Input GetInputfromGroup();
		void GetInputPrepend();
		void IsInputGroupDisabled();

		void GetInputAppend();

	}
}
	