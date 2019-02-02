using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    public GameObject plane, spawn;
 

	// Update is called once per frame
	void Update () {
         //restart();
		float Vertical = Input.GetAxis("Vertical"); // Z
		float Horizontal = Input.GetAxis("Horizontal"); //X

		if(Vertical > 0)
		{
            transform.Translate(0, 0 , 0.05f* 0.6f);

		}
		if(Vertical < 0)
		{
            transform.Translate(0, 0 , -0.05f* 0.6f);

		}

		if(Horizontal > 0)
		{
            transform.Translate(0.05f* 0.6f, 0, 0);

		}
		if(Horizontal < 0)
		{
            transform.Translate(-0.05f* 0.6f, 0, 0);

		}
	}

    void restart()
    {
        if (transform.position.y < plane.transform.position.y)
        {
            //transform.position = Vector3.zero;
            transform.position = spawn.transform.position;
            //transform.localScale += transform.localScale;
        }
    }

}
