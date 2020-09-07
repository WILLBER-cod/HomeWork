using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Animator _anim;
    private Rigidbody2D _body;

    private void Start()
    {
        _anim = GetComponent<Animator>();

        _body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            IsRun(true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            IsRun(false);
        }
        else
            _anim.SetBool("Run", false);

        if (Input.GetKeyDown(KeyCode.Space))
            _body.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }

    private void IsRun(bool IsRight = false)
    {
        _anim.SetBool("Run", true);

        if( IsRight == true)
            transform.Translate(Vector2.right * _speed * Time.deltaTime);
        else
            transform.Translate(Vector2.left * _speed * Time.deltaTime);

    }
}
