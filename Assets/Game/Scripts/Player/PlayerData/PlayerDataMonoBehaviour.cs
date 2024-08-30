using UnityEngine;

public class PlayerDataMonoBehaviour : MonoBehaviour
{
    [field: SerializeField] public string Name { get; set; }
    [field: SerializeField] public string SpaceSuitColor { get; set; }
    [field: SerializeField] public Sprite Weapon { get; set; }
    [field: SerializeField] public Sprite Helmet { get; set; }


}
