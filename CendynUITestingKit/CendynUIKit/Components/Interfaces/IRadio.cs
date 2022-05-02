namespace CendynUIKit.Models
{
    public interface IRadio
    {
        bool IsEnabled();
        bool IsSelected();
        ILabel GetLabel();
        void Select();
        RadioStyle GetRadioStyle();
    }

    public enum RadioStyle
	{
        OptionThenLabel,
        LabelThenOption,
        NoLabel
	}
}
