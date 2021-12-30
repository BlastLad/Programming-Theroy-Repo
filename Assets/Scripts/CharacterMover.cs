using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float speed
    {
        get
        {
            return m_speed;
        }
        set
        {
            if (value < 0)
            {
                Debug.Log("number for speed can't be negative");
            }
            else
            {
                m_speed = value;
            }
        }
    }
    float m_speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            MoveUp();
        }
        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            MoveDown();
        }
    }


    private void MoveUp()
    {
        transform.Translate(Vector3.forward * m_speed * Time.deltaTime);
        if (transform.position.z > -3.91f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -3.91f);
        }
    }

    private void MoveDown()
    {
        transform.Translate(Vector3.back * m_speed * Time.deltaTime);
        if (transform.position.z < -15.43f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -15.43f);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        PrimaryGameManager.Instance.EndGame();
    }
}
