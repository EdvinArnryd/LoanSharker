using UnityEngine;

public class ResultManager : MonoBehaviour
{
    [SerializeField] private GameObject _resultPanel;

    public void ContinueButton()
    {
        _resultPanel.SetActive(false);
    }

    public void EndDayButton()
    {
        _resultPanel.SetActive(true);
    }
}
