using UnityEngine;
using System.Collections;

public class TestScript: MonoBehaviour {

    public GameObject camera;
    public GameObject gameObject;
    public int rotationAmount = 1;
    // Update is called once per frame
    
        Vector3 camera = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -gameObject.transform.position.x);

	void Update()
	{
		if (GameObject.IsVisibleFrom(Camera.main)) Debug.Log("devant la caméra");
		else Debug.Log("derrière la caméra");
	}
}