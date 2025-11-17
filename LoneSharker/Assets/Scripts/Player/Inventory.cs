using System;
using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
    [SerializeField] private int _startBalance = 5000;
    private int _currentBalance;

    public event Action<int> OnBalanceUpdated;

    void Start()
    {
        _currentBalance = _startBalance;
        StartCoroutine(StartGameCoroutine());
    }

    IEnumerator StartGameCoroutine()
    {
        yield return new WaitForSeconds(0.01f);
        OnBalanceUpdated?.Invoke(_currentBalance);
    }

    public void AddToBalance(int addAmount)
    {
        _currentBalance += addAmount;
        OnBalanceUpdated?.Invoke(_currentBalance);
    }

    public void SubtractBalance(int addAmount)
    {
        _currentBalance -= addAmount;
        OnBalanceUpdated?.Invoke(_currentBalance);
    }
}
