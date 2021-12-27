using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickM_LJY : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    RectTransform rect;
    Vector2 touch;
    public RectTransform handle;

    float widthHalf;
    public JoystickValue_LJY value;
    private void Start()
    {
        rect = GetComponent<RectTransform>();
        widthHalf = rect.sizeDelta.x * 0.5f;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 touch = (eventData.position - rect.anchoredPosition) / widthHalf;
        if (touch.magnitude > 1)
            touch = touch.normalized;
        value.joyTouch = touch;
        handle.anchoredPosition = touch * widthHalf;

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        handle.anchoredPosition = Vector2.zero;
        value.joyTouch = Vector2.zero;
    }


}