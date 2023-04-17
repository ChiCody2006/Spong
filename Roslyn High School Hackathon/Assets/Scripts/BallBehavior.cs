using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] SpriteRenderer color;
    private LogicBehavior logic;
    // Start is called before the first frame update
    void Start()
    {
        setDir();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        if(logic.finish)
        {
            rigidbody.velocity = new Vector2(0,0);
        }
    }

    public void setDir()
    {
        
        float xDir = 1;
        float yDir = Random.Range(.5f, 1);
        if (Random.Range(0, 10) >= 5)
        {
            xDir *= -1;
        }
        if (Random.Range(0, 10) >= 5)
        {
            yDir *= -1;
        }
        rigidbody.velocity = new Vector2(xDir, yDir) * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        color.color = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));
    }

}
