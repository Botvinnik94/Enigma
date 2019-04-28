using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigma
{
    class Log
    {
        public ObservableCollection<string> Entries { get; }

        public Log()
        {
            Entries = new ObservableCollection<string>();
        }
    }
}