namespace HotKeysManager
{
    public interface IHotKeyScope
    {
        bool HotKeyContain(HotKeyModel hotKeyModel);
        void ExecuteHotKey(HotKeyModel hotKeyModel);
    }
}
