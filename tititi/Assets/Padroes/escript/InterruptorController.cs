using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InterruptorController : MonoBehaviour
{
    [SerializeField] private Animator myFSM;

    private SpriteRenderer _spriteRenderer;

    
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            myFSM.SetTrigger("Space");
        }
    }

    public void ChangeColor(Color color)
    {
        _spriteRenderer.color = color;
    }
}
