using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerWithKeyboard : MonoBehaviour
{
    void Update()
    {
		if(Input.GetKeyDown("left"))
		{
			this.transform.position += new Vector3(-1, 0, 0);
		}

		if(Input.GetKeyDown("right"))
		{
			this.transform.position += new Vector3(1, 0, 0);
		}
		if(Input.GetKeyDown("up"))
		{
			this.transform.position += new Vector3(0, 1, 0);
		}

		if(Input.GetKeyDown("down"))
		{
			this.transform.position += new Vector3(0, -1, 0);
		}

		if(Input.GetKeyDown("space"))
		{
			this.transform.position = new Vector3(0, 0, 0);
		}
    }
}
