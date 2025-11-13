using TMPro;
using UnityEngine;

public class HudPresenter : MonoBehaviour
{
    [SerializeField] DayManager _dayManager;

    [SerializeField] TMP_Text _dayText;
    void Start()
    {
        _dayManager.OnDayEnded += UpdateUIOnDayEnded;
    }

    private void UpdateUIOnDayEnded(int day)
    {
        _dayText.text = day.ToString();
    }
}
