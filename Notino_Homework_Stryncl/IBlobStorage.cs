using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notino_Homework_Stryncl
{
    /// <summary>
    /// Uloží binární obsah dle implementace
    /// </summary>
    public interface IBlobStorage
    {
        string ReadAsString(string filePathOrUrl);

        void SaveContent(string targetFileName, byte[] data);
    }
}
