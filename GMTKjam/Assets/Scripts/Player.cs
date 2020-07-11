using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class Player : MonoBehaviour
{
    CharacterController cc;

    private void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue inputValue)
    {
        float hor = inputValue.Get<Vector2>().x;
        float ver = inputValue.Get<Vector2>().y;
        cc.Move(new Vector3(hor, 0, ver));
    }
}
