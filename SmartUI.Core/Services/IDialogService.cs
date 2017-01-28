using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUI.Core.Services
{
    public interface IDialogService
    {
        bool? Ask(string message, string caption = null, bool cancelable = false);

        bool OpenFile(out string fileName, string filter = null, string caption = null);

        bool OpenFiles(out List<string> fileNames, string filter = null, string caption = null);

        bool SaveFile(out string fileName, string caption = null, string filter = null);

        bool BrowseFolder(out string folder);

        bool Input(out string text);
    }
}
