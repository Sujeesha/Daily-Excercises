namespace Locker
{
    public class BankLocker
    {
        int _number;
        string _lockType;
        string _password;
        double _amount;
        DateTime _lastOpened;

    }
    public BankLocker()
    {

    }
    public BankLocker(int _number,string _lockType,string _password,double _amount,DateTime _lastOpened)
    {
        this._number = _number;
        this._lockType = _lockType;
        this._password = _password;
        this._amount = _amount;
        this._lastOpened = _lastOpened;
    }

}