using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Buttons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public AudioSource HoverSound;

    void Awake()
    {
        HoverSound = GetComponent<AudioSource>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = new Vector3(transform.localScale.x * 1.1f, transform.localScale.y * 1.1f, transform.localScale.z * 1.1f);
        HoverSound.Play();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = new Vector3(transform.localScale.x / 1.1f, transform.localScale.y / 1.1f, transform.localScale.z / 1.1f);
    }
}
