using UnityEngine;

public class ObservableInt
{
    public System.Action<int> _numberChange;
    public int _number;
    
    public int Number
    {
        get => _number;
        set
        {
            _numberChange?.Invoke(value);
            _number = value;
        }
    }

    public ObservableInt(int number = 0, System.Action<int> numberChange = null)
    {
        _number = number;
        _numberChange = numberChange;
    }
}
