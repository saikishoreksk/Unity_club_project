using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class playermoves : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float jumpforce;


    private float horizantalAxis;

    private Rigidbody2D _rd;

    // Start is called before the first frame update
    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        //_rd.transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0.0f, 0.0f));
        //_rd.AddForce(new Vector2(moveSpeed, 0.0f), ForceMode2D.Force);
        _rd.velocity = new Vector2(moveSpeed * horizantalAxis, _rd.velocity.y);


    }
    public void OnMove(InputAction.CallbackContext context)
    {
        horizantalAxis = context.ReadValue<float>();
        Debug.Log(context);

    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
            _rd.AddForce(new Vector2(0.0f, jumpforce), ForceMode2D.Impulse);

    }

}