using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PADIP
{
    public interface IPageService
    {
        Task<bool> DisplayAlert(string title, string message, string ok, string cancel);
    }
}
