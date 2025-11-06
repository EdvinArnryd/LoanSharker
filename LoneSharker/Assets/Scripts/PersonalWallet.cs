using TMPro;
using UnityEngine;

public class PersonalWallet : MonoBehaviour
{
    [SerializeField] private float _money = 500;
    [SerializeField] private TMP_Text _currentMoney;

    public float Money => _money;

    void Start()
    {
        UpdateMoney();
    }

    public void UpdateMoney()
    {
        _currentMoney.text = _money.ToString();
    }

    public void IncreaseMoney(float amount)
    {
        _money += amount;
        UpdateMoney();
    }

    public float DecreaseMoney(float amount)
    {
        _money -= amount;
        UpdateMoney();
        
        return amount;
    }
}
