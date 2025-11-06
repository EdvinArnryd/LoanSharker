using TMPro;
using UnityEngine;

public class InvestmentSystem : MonoBehaviour
{
    [SerializeField] PersonalWallet _wallet;
    [SerializeField] TMP_Text _investmentAmountTxt;
    [SerializeField] TMP_Text _investmentRevenueTxt;
    [SerializeField] private DayTracker _dayTracker;

    private float _investmentAmount = 0;
    private float _investmentPrice = 50;
    private float _investmentRevenuePercent = 0.12f;


    private void Start()
    {
        _dayTracker.DayEndedHandler += CalculateRevenue;
    }

    private void OnDestroy()
    {
        _dayTracker.DayEndedHandler -= CalculateRevenue;
    }

    private void CalculateRevenue()
    {
        float revenue = _investmentAmount * _investmentRevenuePercent;

        _investmentRevenueTxt.text = revenue.ToString();

        _wallet.IncreaseMoney(revenue);
    }
    
    public void Invest()
    {
        if (_wallet.Money < _investmentPrice)
        {
            // Disable button 
            return;
        }
        _investmentAmount += _wallet.DecreaseMoney(_investmentPrice);
        _investmentAmountTxt.text = _investmentAmount.ToString();
    }
    

}
