using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour
{
    public GameObject Boom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0, -0.1f, 0);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Cousin" || col.tag == "Bullet")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);

            Instantiate(Boom, transform.position, transform.rotation);
            if(col.tag == "cousin")
            {
                Instantiate(Boom, col.gameObject.transform.position, col.gameObject.transform.rotation);

                GameFunction.Instance.GameOver();
            }
            GameFunction.Instance.AddScore();
        }
    }
}
