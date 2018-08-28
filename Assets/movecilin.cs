using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecilin : MonoBehaviour {

    Renderer rend;
    public Material vremeio;
    public Material vrede;

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody>();
	}


    bool colidiu;
	// Update is called once per frame
	void Update () {




        if (colidiu)
        {
            rb.isKinematic = false;
            rb.velocity = new Vector3(0, 0, 0);
        }
		else if (transform.position.y > 3)
        {
			transform.position = new Vector3(transform.position.x - 0.05f, transform.position.y, transform.position.z);

            if (transform.position.x < -3.5f)
            {
                transform.position = new Vector3(3.5f, transform.position.y, transform.position.z);
            }
        }

		else if (transform.position.y < 3)
		{
			transform.position = new Vector3(transform.position.x + 0.05f, transform.position.y, transform.position.z);

			if (transform.position.x > 3.5f)
			{
				transform.position = new Vector3(-3.5f, transform.position.y, transform.position.z);
			}
		}

	}

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "shot")
        {
            print("cu");
            rend.material = vrede;
            colidiu = true;
        }
    }
}
