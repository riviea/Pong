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
        int x = Random.Range(0, 2) == 0 ? -1 : 1;
        int y = Random.Range(0, 2) == 0 ? -1 : 1;
        dirVec = new Vector2(x, y); //gameObject.transform.right;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += (new Vector3(dirVec.x, dirVec.y) * speed) * Time.deltaTime;
    }

    Vector3 ReflectVector(Vector3 pos)
    {
        return new Vector3(pos.x, pos.y, pos.z);
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
