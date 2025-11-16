using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalendarM : MonoBehaviour
{
    [SerializeField] Transform _contentTransform;
    [SerializeField] CalendarDayButton _calendarDayButtonPrefab;
    [SerializeField] DayManager _dayManager;
    private List<CalculatorButton> _calendarDayButtons;

    void Start()
    {
        _dayManager.OnDayEnded += HandleOnNewDay;

        for (int i = 1; i <= 31; i++)
        {
            CalendarDayButton newButton = _calendarDayButtonPrefab;
            newButton._text.text = i.ToString();
            newButton.name = "Day:" + i;
            Instantiate(newButton, _contentTransform);
        }

        HandleOnNewDay(1);
    }

    private void HandleOnNewDay(int day)
    {
        Transform child = _contentTransform.GetChild(day-1);
        child.GetComponent<Image>().color = Color.blue;
    }
}
