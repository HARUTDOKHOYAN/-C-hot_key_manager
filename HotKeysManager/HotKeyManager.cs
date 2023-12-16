using System;
using System.Collections.Generic;
using System.Text;

namespace HotKeysManager
{
    public class HotKeyManager
    {
        private IHotKeyScope _scop;


        public void RegisterHotKeyScope(IHotKeyScope scop )
        {
            _scop = scop;
        }

        public void ExecutesHotKey(HotKeyModel hotKey)
        {
            if (_scop.HotKeyContain(hotKey))
                _scop.ExecuteHotKey(hotKey);
        }
    }
}
