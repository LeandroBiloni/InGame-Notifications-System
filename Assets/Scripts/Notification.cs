using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Notification : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private NotificationType _notificationType; 
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private  Image _image;
    [SerializeField] private  Image _background;
    private float _showTime = 5f;
    private float _currentTime;
    private float _fadeSpeed = 5f;
    private CanvasGroup _canvasGroup;
    private bool _disappear;
    private void Start()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        
        _canvasGroup.alpha = 0;
        
        StartCoroutine(FadeIn());
    }

    private void Update()
    {
        if (_disappear) return;
        
        _currentTime += Time.deltaTime;

        if (_currentTime >= _showTime)
        {
            _disappear = true;
            StopAllCoroutines();
            StartCoroutine(FadeOut());
        }
    }

    public void Initialize(NotificationDataSO data)
    {
        _text.text = data.message;

        _text.color = data.textColor;

        if (data.icon)
        {
            _image.gameObject.SetActive(true);
            _image.sprite = data.icon;
        }
        
        if (data.background)
        {
            _background.sprite = data.background;
        }
        
        _background.color = data.backgroundColor;
        
        _showTime = data.showTime;
        
        _fadeSpeed = data.fadeSpeed;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _disappear = true;
        _canvasGroup.interactable = false;
        _canvasGroup.blocksRaycasts = false;
        StopAllCoroutines();
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        float time = 0;

        while (_canvasGroup.alpha > 0)
        {
            time += Time.deltaTime;
            _canvasGroup.alpha -= time / _fadeSpeed;
            
            yield return new WaitForEndOfFrame();
        }
        
        Destroy(gameObject);
    }
    
    IEnumerator FadeIn()
    {
        float time = 0;

        _canvasGroup.alpha = 0;
        while (_canvasGroup.alpha < 1)
        {
            time += Time.deltaTime;
            _canvasGroup.alpha += time / _fadeSpeed;
            
            yield return new WaitForEndOfFrame();
        }
    }

    public NotificationType GetNotificationType()
    {
        return _notificationType;
    }
}
