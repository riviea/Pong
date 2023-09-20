using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    private PaddleInputController _controller;
    private Vector2 _moveDir;
    [SerializeField] private float _moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<PaddleInputController>();
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(_moveDir.x, _moveDir.y)*Time.deltaTime;
    }

    void Move(Vector2 newDir)
    {
        _moveDir = newDir*_moveSpeed;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("tagtagtagtagtag");
        if (collision.gameObject.CompareTag("Wall"))
            _moveDir = Vector2.zero;
    }
}
