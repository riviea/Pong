using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    public Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.transform.forward.ToString());
        Launch();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void Launch()
    {
        int x = Random.Range(0, 2) == 0 ? -1 : 1;
        int y = Random.Range(0, 2) == 0 ? -1 : 1;
        rigidBody.velocity = new Vector2(x, y) * speed; //gameObject.transform.right;
    }

    public void Reset()
    {
        rigidBody.velocity = Vector2.zero;
        transform.position = Vector2.zero;
        Launch();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Touch");
        }
    }
}
