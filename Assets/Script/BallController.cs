using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Vector2 dirVec;
    [SerializeField] private float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.transform.forward.ToString());
        dirVec = gameObject.transform.right;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += (new Vector3(dirVec.x, dirVec.y) * speed) * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("1");
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Touch");
            dirVec *= new Vector3(-1, -1);
        }
    }
}
