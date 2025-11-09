using System;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public static Calculator _Instance;
    private int _currentResult;
    public int _CurrentResult => _currentResult;

    public event Action<int> OnResultUpdated;

    private void Awake()
    {
        _Instance = this;
    }

    /// <summary>
    /// Takes in any generic value and updates the current result with the returned value
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="value"></param>
    public void CalculateNumber(int value)
    {
        if (_currentResult == 0)
        {
            _currentResult = value;
        }
        else
        {
            _currentResult = _currentResult * 10 + value;
        }
        OnResultUpdated?.Invoke(_currentResult);
    }
}
