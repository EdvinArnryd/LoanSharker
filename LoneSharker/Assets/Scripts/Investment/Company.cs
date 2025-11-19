using UnityEngine;

public class Company : MonoBehaviour
{
    [SerializeField] private DayManager _dayManager;
    [SerializeField] private int _startStockPrice;
    private int _currentStockPrice;

    private void Start()
    {
        _dayManager.OnDayEnded += CalculateStockPrice;
    }

    private void CalculateStockPrice(int day)
    {
        
    }
}
