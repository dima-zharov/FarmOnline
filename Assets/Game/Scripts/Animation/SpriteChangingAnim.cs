using System.Collections.Generic;
using UnityEngine;

public class SpriteChangingAnim : MonoBehaviour
{
    [SerializeField] private float _timeWaitingToNextFrame;
    [SerializeField] private List<Sprite> _spriteList;
    private int frame;
    private SpriteRenderer _spriteRenderer;
    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        Invoke(nameof(ChangeSprite), _timeWaitingToNextFrame);
    }

    private void ChangeSprite()
    {
        frame++;

        if (frame >= _spriteList.Count)
        {
            frame = 0;
        }

        if (frame >= 0 && frame < _spriteList.Count)
        {
            _spriteRenderer.sprite = _spriteList[frame];
        }

        Invoke(nameof(ChangeSprite), _timeWaitingToNextFrame);
    }
}
