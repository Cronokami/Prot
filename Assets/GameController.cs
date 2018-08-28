using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;


        placeTargets();
		menuInicial ();

    }

    public GameObject target;


    void placeTargets()
    {
        for(int i = 0; i < 7; i++)
        {
            Instantiate(target, new Vector3(-2.5f + i, 4.5f, 9.5f), Quaternion.identity);

			Instantiate(target, new Vector3(-2.5f + i, 2f, 9.5f), Quaternion.identity);

        }
    }

	void menuInicial()
	{
		//coisas do GUI, n sei se rola

	}



	// Update is called once per frame
	void Update () {
		
	}
}
