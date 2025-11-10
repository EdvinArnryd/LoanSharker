using System;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    private int _cachedValue;
    private bool _isValueCached;
    private char _cachedOperator;
    private int _currentResult;
    public int _CurrentResult => _currentResult;
    public static Calculator _Instance;
    public event Action<int> OnResultUpdated;

    private void Start()
    {
        _Instance = this;
        _currentResult = 0;
        OnResultUpdated?.Invoke(_currentResult);
    }

    /// <summary>
    /// Adds any digit to the result 
    /// </summary>
    /// <typeparam name="char"></typeparam>
    /// <param name="value"></param>
    private void CalculateChar(char value)
    {
        // Subtracting with '0' because calculation with chars uses ASCII
        // This will "reset" the value since '0' = 47 and '1' = 48 etc...
        int digit = value - '0';

        if(_isValueCached)
        {
            _isValueCached = false;
            _currentResult = digit;
            OnResultUpdated?.Invoke(_currentResult);
            return;
        }
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
    /// Clears the result 
    /// </summary>
    private void Clear()
    {
        _currentResult = 0;
        OnResultUpdated?.Invoke(_currentResult);
    }

    /// <summary>
    /// Removes the last digit 
    /// </summary>
    private void Backspace()
    {
        _currentResult /= 10;
        OnResultUpdated?.Invoke(_currentResult);
    }

    private void Maths(char _operator)
    {
        switch(_operator)
        {
            case '+':
                _currentResult = _cachedValue + _currentResult;
                OnResultUpdated?.Invoke(_currentResult);
                break;
        }
    }

    /// <summary>
    /// Handles the button press logic depending on the char
    /// </summary>
    /// <typeparam name="char"></typeparam>
    /// <param name="buttonResult"></param>

    public void EvaluateButtonResult(char buttonResult)
    {
        switch(buttonResult)
        {
            case '/':
                if(_isValueCached)
                    Maths(buttonResult);
                _cachedOperator = buttonResult;
                _cachedValue = _currentResult;
                _isValueCached = true;
                break;
            case '*':
                if (_isValueCached)
                    Maths(buttonResult);
                _cachedOperator = buttonResult;
                _cachedValue = _currentResult;
                _isValueCached = true;
                break;
            case '+':
                if (_isValueCached)
                    Maths(buttonResult);
                else
                {
                    _cachedValue = _currentResult;
                    _isValueCached = true;
                    _cachedOperator = buttonResult;
                    print(_cachedValue);
                }
                break;
            case '-':
                if (_isValueCached)
                    Maths(buttonResult);
                _cachedOperator = buttonResult;
                _cachedValue = _currentResult;
                _isValueCached = true;
                break;
            case 'c':
                Clear();
                break;
            case '<':
                Backspace();
                break;
            case '0':
                CalculateChar(buttonResult);
                break;
            case '1':
                CalculateChar(buttonResult);
                break;
            case '2':
                CalculateChar(buttonResult);
                break;
            case '3':
                CalculateChar(buttonResult);
                break;
            case '4':
                CalculateChar(buttonResult);
                break;
            case '5':
                CalculateChar(buttonResult);
                break;
            case '6':
                CalculateChar(buttonResult);
                break;
            case '7':
                CalculateChar(buttonResult);
                break;
            case '8':
                CalculateChar(buttonResult);
                break;
            case '9':
                CalculateChar(buttonResult);
                break;
        }
    }
}
