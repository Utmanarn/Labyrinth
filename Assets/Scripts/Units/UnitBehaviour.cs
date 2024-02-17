using UnityEngine;

public class UnitBehaviour : MonoBehaviour
{
    private SpriteRenderer _sprRenderer;
    private GameObject _selectionCircle;

    private GroupLeader _leader;
    
    void Start()
    {
        _sprRenderer = GetComponent<SpriteRenderer>();
        
        _sprRenderer.color = Color.white; // Set default colour.
    }
    
    void Update()
    {
        
    }
}
