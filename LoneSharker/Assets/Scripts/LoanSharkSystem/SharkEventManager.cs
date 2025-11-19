using TMPro;
using UnityEngine;

public class SharkEventManager : MonoBehaviour
{
    [SerializeField] private GameObject _eventPanel;
    [SerializeField] private TMP_Text _eventText;
    [SerializeField] private AngerMeter _angerSystem;

    private void Start()
    {
        _angerSystem.CallingPhoneHandler += PhoneEvent;
        _angerSystem.KnockingOnDoorHandler += DoorEvent;
    }

    private void PhoneEvent()
    {
        _eventPanel.SetActive(true);
        _eventText.text = "The phone is ringing!";
    }

    private void DoorEvent()
    {
        _eventPanel.SetActive(true);
        _eventText.text = "Someone is knocking on the door. They sound angry!";
    }
    
    public void ContinueButton()
    {
        _eventPanel.SetActive(false);
    }

}
