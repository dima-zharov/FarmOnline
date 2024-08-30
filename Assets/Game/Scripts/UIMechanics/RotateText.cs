using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshPro))]
public class RotateNicknameText : MonoBehaviour
{

    private RectTransform _transform;
    private void Start()
    {
        _transform = GetComponent<RectTransform>();
    }
    private void LateUpdate()
    {
        RotateY(0);
    }

    private void RotateY(int angle)
    {
        _transform.rotation = Quaternion.Euler(new Vector2(0, angle));
    }
}
