using System;
using System.Collections.Generic;
using System.Text;

namespace CTOS.Models
{
    public interface ICard
    {
        string Header { get; }
        string Title { get; }
        string Body { get; }
        string Footer { get; }
        string Image { get; }
    }
}