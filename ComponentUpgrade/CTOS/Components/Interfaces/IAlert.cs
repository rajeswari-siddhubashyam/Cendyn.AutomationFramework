using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CTOS.Components
{
	public interface IAlert
	{
		Color GetBackgroundColor();
		AlertType GetAlertType();
		string GetText();
		string GetIcon();
		void CloseAlert();
	}

	public enum AlertType
	{
		Primary,
		Secondary,
		Success,
		Info,
		Warning,
		Danger,
		Light,
		Dark,
		None
	}
}
