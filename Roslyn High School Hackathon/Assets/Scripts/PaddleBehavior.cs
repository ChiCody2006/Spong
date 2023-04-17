using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBehavior : MonoBehaviour
{
    [SerializeField] int player;
    [SerializeField] float speed;
    [SerializeField] float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        if(player==1)
        {
            if(Input.GetKey(KeyCode.W))
            {
                gameObject.transform.position += new Vector3(0, speed*Time.deltaTime, 0);
            }
            if(Input.GetKey(KeyCode.S))
            {
                gameObject.transform.position += new Vector3(0, -1 * speed*Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(new Vector3(0, 0, -1 * rotateSpeed*Time.deltaTime));
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(new Vector3(0, 0, rotateSpeed*Time.deltaTime));
            }
            if(Input.GetKey(KeyCode.LeftShift))
            {
                if (Input.GetKey(KeyCode.W))
                {
                    gameObject.transform.position += new Vector3(0, -1 * speed * Time.deltaTime, 0);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    gameObject.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    transform.Rotate(new Vector3(0, 0, -1 * rotateSpeed * Time.deltaTime*5));
                }
                if (Input.GetKey(KeyCode.A))
                {
                    transform.Rotate(new Vector3(0, 0, rotateSpeed * Time.deltaTime*5));
                }
            }
        } else if(player==2)
        {
            
            if (Input.GetKey(KeyCode.UpArrow))
            {
                gameObject.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                gameObject.transform.position += new Vector3(0, -1 * speed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(new Vector3(0, 0, -1 * rotateSpeed * Time.deltaTime));
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(new Vector3(0, 0, rotateSpeed * Time.deltaTime));
            }
            if(Input.GetKey(KeyCode.RightShift))
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    gameObject.transform.position += new Vector3(0, -1 * speed * Time.deltaTime, 0);
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    gameObject.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
                }
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    transform.Rotate(new Vector3(0, 0, -1 * rotateSpeed * Time.deltaTime*5));
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    transform.Rotate(new Vector3(0, 0, rotateSpeed * Time.deltaTime*5));
                }
            }
        }
    }
}
