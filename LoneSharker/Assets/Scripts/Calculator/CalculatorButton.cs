using UnityEngine;

public class CalculatorButton : MonoBehaviour
{
    [SerializeField] private int _buttonValue;
    public void OnButtonClick()
    {
        Calculator._Instance.CalculateNumber(_buttonValue);
    }
}
