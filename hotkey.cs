interface IExecutable 
        {
        void Execute();
        }
class EditorAction:IExecutaable
{
        _e;
        _handler;
    EditorAction(EitorCore e, Action<EditorCore> handler)
    {
        _e - e;
        _handler = handler;
    }
    public void Execute()
    {
        _hendler(_e);
    }
}

class EsimInchAction:IExecutale{
        
EsimInchAction(EsimINch1 e1, EsimInch2 e2,Action<EsimINch1 ,EsimInch2 > handler  ){}
        
Execute()
{
    handler(e1, e2);
}
        
        }