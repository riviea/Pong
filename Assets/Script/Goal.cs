using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] bool isPlayer1Goal;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touch Ball");
        if (collision.gameObject.name.Equals("Ball"))
        {
            if (isPlayer1Goal)
            {
                gameManager.Player2Scored();
            }
            else
            {
                gameManager.Player1Scored();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
