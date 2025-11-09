using System;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public static Calculator _Instance;
    private int _currentResult;
    public int _CurrentResult => _currentResult;

    public event Action<int> OnResultUpdated;

    private void Start()
    {
        _Instance = this;
        _currentResult = 0;
        OnResultUpdated?.Invoke(_currentResult);
    }

    /// <summary>
    /// Takes in an int
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="value"></param>
    private void CalculateChar(char value)
    {
        // Subtracting with '0' because calculation with chars uses ASCII
        // This will "reset" the value since '0' = 47 and '1' = 48 etc...
        int digit = value - '0';
        if (_currentResult == 0)
        {
            _currentResult = digit;
        }
        else
        {
            _currentResult = _currentResult * 10 + digit;
        }
        OnResultUpdated?.Invoke(_currentResult);
    }

    /// <summary>
    /// Clear
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="value"></param>
    private void Clear()
    {
        _currentResult = 0;
        OnResultUpdated?.Invoke(_currentResult);
    }

    /// <summary>
    /// Takes in an char
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="value"></param>

    public void CalculateNumber(char value)
    {
        switch(value)
        {
            case '/':
                print("division");
                break;
            case '*':
                print("multilpy");
                break;
            case '+':
                print("addition");
                break;
            case '-':
                print("subtraction");
                break;
            case 'c':
                Clear();
                break;
            case '0':
                CalculateChar(value);
                break;
            case '1':
                CalculateChar(value);
                break;
            case '2':
                CalculateChar(value);
                break;
            case '3':
                CalculateChar(value);
                break;
            case '4':
                CalculateChar(value);
                break;
            case '5':
                CalculateChar(value);
                break;
            case '6':
                CalculateChar(value);
                break;
            case '7':
                CalculateChar(value);
                break;
            case '8':
                CalculateChar(value);
                break;
            case '9':
                CalculateChar(value);
                break;
        }
    }
}
