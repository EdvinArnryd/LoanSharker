using UnityEngine;

public class CalculatorButton : MonoBehaviour
{
    [SerializeField] private char _buttonValue;
    public void OnButtonClick()
    {
        Calculator._Instance.EvaluateButtonResult(_buttonValue);
    }
}
