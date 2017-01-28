using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUI.Core.Services
{
    public interface IMessageBoxService
    {
        void ShowError(string message, string caption = null);

        void ShowError(Exception exception, string caption = null);

        void ShowWarning(string message, string caption = null);

        void ShowInfo(string message, string caption = null);
    }
}
