using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DayTracker : MonoBehaviour
{
    private int _currentDay = 1;

    [SerializeField] private TMP_Text _currentDayTxt;

    public event Action DayEndedHandler;


    void Start()
    {
        _currentDayTxt.text = _currentDay.ToString();
    }

    public void IncrementDay()
    {
        _currentDay++;
        print(_currentDay);
        _currentDayTxt.text = _currentDay.ToString();
        
        DayEndedHandler?.Invoke();
    }
}
