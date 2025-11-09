using TMPro;
using UnityEngine;

public class CalculatorUIHandler : MonoBehaviour
{
    [SerializeField] TMP_Text _resultText;
    void Start()
    {
        Calculator._Instance.OnResultUpdated += UpdateUI;
    }


    private void UpdateUI(int value)
    {
        _resultText.text = value.ToString();
    }
}
