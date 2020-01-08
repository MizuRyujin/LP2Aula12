using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Model")]
public class EnemyModel : ScriptableObject
{
    [SerializeField]
    private Sprite _sprite = null;
    [SerializeField]
    private Color _color = default;
    public Sprite Sprite => _sprite;
    public Color Color => _color;
}
