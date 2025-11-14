using System;
using System.Collections;
using UnityEngine;

public class DayManager : MonoBehaviour
{
    private int _currentDay;

    public event Action<int> OnDayEnded;


    void Awake()
    {
        _currentDay = 1;

        StartCoroutine(StartGameCoroutine());
    }

    IEnumerator StartGameCoroutine()
    {
        yield return new WaitForSeconds(0.01f);
        OnDayEnded?.Invoke(_currentDay);
    }
    
    public void EndDay()
    {
        _currentDay++;

        OnDayEnded?.Invoke(_currentDay);
    }
}
