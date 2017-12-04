using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mos = Input.mousePosition;
            mos.z = Camera.main.farClipPlane;
            Vector3 dir = Camera.main.ScreenToWorldPoint(mos);

            RaycastHit hit;
            if (Physics.Raycast(transform.position, dir, out hit, mos.z))
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = hit.point;
            }
        }
    }
}
