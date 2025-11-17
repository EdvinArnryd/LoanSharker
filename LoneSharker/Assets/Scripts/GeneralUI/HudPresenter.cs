using TMPro;
using UnityEngine;

public class HudPresenter : MonoBehaviour
{
    [SerializeField] private DayManager _dayManager;
    [SerializeField] private Inventory _inventory;
    [SerializeField] private TMP_Text _balanceText;
    [SerializeField] private TMP_Text _dayText;
    void Start()
    {
        _dayManager.OnDayEnded += UpdateDayText;
        _inventory.OnBalanceUpdated += UpdateBalanceText;
    }

    private void UpdateDayText(int day)
    {
        _dayText.text = "Day: " + day.ToString();
    }

    private void UpdateBalanceText(int balance)
    {
        _balanceText.text = "$" + balance.ToString();
    }
}
