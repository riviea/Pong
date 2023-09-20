using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 inputVec = new Vector2(0,0);
    [SerializeField] private float speed = 5f;
    [SerializeField] KeyCode MoveUp, MoveDown;

    [SerializeField] KeyCode MoveLeft, MoveRight;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(MoveUp))
        {
            inputVec = new Vector2(0, 1f);
            gameObject.transform.Translate((new Vector3(inputVec.x, inputVec.y).normalized * speed) * Time.deltaTime);
        }
        else if (Input.GetKey(MoveDown))
        {
            inputVec = new Vector2(0, -1f);
            gameObject.transform.Translate((new Vector3(inputVec.x, inputVec.y).normalized * speed) * Time.deltaTime);
        }
        else if (Input.GetKey(MoveLeft))
        {
            inputVec = new Vector2(-1f, 0);
            gameObject.transform.Translate((new Vector3(inputVec.x, inputVec.y).normalized * speed) * Time.deltaTime);
        }
        else if (Input.GetKey(MoveRight))
        {
            inputVec = new Vector2(1f, 0);
            gameObject.transform.Translate((new Vector3(inputVec.x, inputVec.y).normalized * speed) * Time.deltaTime);
        }
        
    }
}
