using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cousincontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 pos = gameObject.transform.position + new Vector3(0, 1f, 0);

            Instantiate(Bullet, pos, gameObject.transform.rotation);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(0.1f, 0, 0);
        }else if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position -= new Vector3(0.1f, 0, 0);
        }else if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.position += new Vector3(0, 0.1f, 0);
        }else if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.position -= new Vector3(0, 0.1f, 0);
        }
    }
}
