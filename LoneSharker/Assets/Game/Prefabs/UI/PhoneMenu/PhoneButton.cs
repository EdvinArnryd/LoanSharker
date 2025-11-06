using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PhoneButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Color _highlightColor;
    [SerializeField] private Color _baseColor;

    public void OnPointerClick(PointerEventData eventData)
    {
        _text.color = _baseColor;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _text.color = _highlightColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _text.color = _baseColor;
        GameObject.Find("EventSystem").GetComponent<EventSystem>().SetSelectedGameObject(null);
    }
}
