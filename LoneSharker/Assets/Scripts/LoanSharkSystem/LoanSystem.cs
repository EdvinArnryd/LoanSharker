using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class LoanSystem : MonoBehaviour
{
    [SerializeField] TMP_Text _debtAmountTxt;
    [SerializeField] TMP_Text _debtIncreaseTxt;

    [SerializeField] private PersonalWallet _wallet;
    [SerializeField] private DayTracker _dayTracker;
    [SerializeField] private float _loanAmount = 100f;
    [SerializeField] private float _interest = 0.30f;
    private float _debtAmount;
    private float _debtIncrease;

    private bool _isInDebt = false;

    public bool IsInDebt => _isInDebt;

    private void Start()
    {
        _dayTracker.DayEndedHandler += CalculateInterest;
    }

    private void OnDestroy()
    {
        _dayTracker.DayEndedHandler -= CalculateInterest;
    }

    public void TakeALoan()
    {
        _wallet.IncreaseMoney(_loanAmount);
        _debtAmount += _loanAmount;
        UpdateDebtTxt();
        _isInDebt = true;
    }

    public void PayBackDebt()
    {
        if (_wallet.Money > _debtAmount)
        {
            _wallet.DecreaseMoney(_debtAmount);
            _debtAmount = 0;
            UpdateDebtTxt();
            _isInDebt = false;
        }
    }

    private void UpdateDebtTxt()
    {
        _debtAmountTxt.text = math.floor(_debtAmount).ToString();
    }

    private void CalculateInterest()
    {
        _debtIncrease = _debtAmount * _interest;
        _debtAmount += _debtIncrease;
        _debtIncreaseTxt.text = math.floor(_debtIncrease).ToString();
        UpdateDebtTxt();
    }
    
}
