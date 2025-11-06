using System;
using UnityEngine;
using UnityEngine.UI;

public class AngerMeter : MonoBehaviour
{

    private float _angerAmount = 0;

    [SerializeField] private DayTracker _dayTracker;
    [SerializeField] private LoanSystem _loanSystem;
    [SerializeField] private Slider _angerSlider;

    public event Action CallingPhoneHandler;

    public event Action KnockingOnDoorHandler;

    private void Start()
    {
        _angerSlider.value = _angerAmount / 10;

        _dayTracker.DayEndedHandler += AngerMeterUpdate;
    }

    private void OnDestroy()
    {
        _dayTracker.DayEndedHandler -= AngerMeterUpdate;
    }

    private void AngerMeterUpdate()
    {
        if (_loanSystem.IsInDebt && _angerAmount < 10)
        {
            _angerAmount++;
            _angerSlider.value = _angerAmount / 10;
            switch(_angerAmount)
            {
                case 3:
                    CallingPhoneHandler?.Invoke();
                    break;
                case 7:
                    KnockingOnDoorHandler?.Invoke();
                    break;
            }
        }
        else if(!_loanSystem.IsInDebt && _angerAmount >= 1)
        {
            _angerAmount--;
            _angerSlider.value = _angerAmount / 10;
        }
    }
}
