using CTOS.Components;

namespace CTOS.Models
{
    public interface IRadio
    {
        bool IsEnabled();
        bool IsSelected();
        Label GetLabel();
        void Select();
    }
}
