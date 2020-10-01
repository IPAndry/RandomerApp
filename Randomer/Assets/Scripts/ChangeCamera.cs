using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCamera : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    [SerializeField] Camera FirstCam;
    [SerializeField] Camera SecondCam;

    [SerializeField] GameObject FirstCanvas;
    [SerializeField] GameObject SecondCanvas;

    public void OnPointerClick(PointerEventData eventData)
    {
        FirstCam.gameObject.SetActive(false);
        SecondCam.gameObject.SetActive(true);

        FirstCanvas.gameObject.SetActive(false);
        SecondCanvas.gameObject.SetActive(true);
    }
}
