using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraScreen : MonoBehaviour, IPointerClickHandler
{

    public GameObject pinkPixel;
    public Camera playerCamera;
    private RectTransform _screenRectTransform;

    private void Awake()
    {
        _screenRectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(_screenRectTransform, eventData.position, null, out Vector2 localClick);
        localClick.y = (_screenRectTransform.rect.yMin * -1) - (localClick.y * -1);
        
        Vector2 viewportClick = new Vector2(localClick.x / _screenRectTransform.rect.xMax,
            localClick.y / (_screenRectTransform.rect.yMin * -1));

        Ray ray = playerCamera.ViewportPointToRay(new Vector3(viewportClick.x, viewportClick.y, 0));
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            GameObject clickPoint = Instantiate(pinkPixel);
            clickPoint.transform.position = hit.point;
        }
    }

}
