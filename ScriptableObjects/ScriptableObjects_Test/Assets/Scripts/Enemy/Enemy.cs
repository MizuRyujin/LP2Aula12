using UnityEngine;

public class Enemy : MonoBehaviour
{
    private SpriteRenderer _sRenderer = null;

    [SerializeField]
    private EnemyModel model = null;

    private void Awake()
    {
        _sRenderer = GetComponent<SpriteRenderer>();
        _sRenderer.sprite = model.Sprite;
    }
}
