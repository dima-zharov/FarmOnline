using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Image))]
public class ChageSpriteActions : MonoBehaviour
{
    [SerializeField] private Sprite _activeSprite;
    [SerializeField] private Sprite _notActiveSprite;
    private Image _image;
    private bool _isActive = false;

    private void Start()
    {
        _image = GetComponent<Image>();
    }
    public void Action()
    {
        _isActive = !_isActive;
        _image.sprite = _isActive ? _activeSprite : _notActiveSprite;
    }

}
