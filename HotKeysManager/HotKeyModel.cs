using System;
using System.Collections.Generic;
using System.Text;

namespace HotKeysManager
{
    public class HotKeyModel
    {
        public string HotKeyName => Modifier + Key;
        public string Modifier { get; set; }

        public string Key { get; set; }
    }
}
