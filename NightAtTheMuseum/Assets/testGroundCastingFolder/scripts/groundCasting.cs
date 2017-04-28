using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCasting : MonoBehaviour {

	private bool travelling = false;
	private Vector3 target;
	private float distanceTransversed;
	private float totalDistance;

	public bool teleport = false;
	public float travellingFrames = 20;
	public float delta = 0.01f;
	public float height = 1f;


	// Update is called once per frame
	void Update () 
	{
		if (travelling) 
		{
			transform.position = Vector3.Lerp (transform.position, target, distanceTransversed / totalDistance);
			distanceTransversed += totalDistance / travellingFrames;

			if (Vector3.Distance (transform.position, target) <= delta) 
			{
				transform.position = target;
				travelling = false;
			}
		}
	}

	public void onMouseClicked()
	{
		if (!travelling && !teleport) 
		{
			RaycastHit hitInfo;
			Ray raycasted = new Ray (transform.position, transform.forward);

			Physics.Raycast (raycasted, out hitInfo);

			travelling = true;
			target = new Vector3 (hitInfo.point.x, hitInfo.point.y + height, hitInfo.point.z);
			totalDistance = Vector3.Distance (transform.position, target);
			distanceTransversed = 0;
		} 
		else if (teleport) 
		{
			RaycastHit hitInfo;
			Ray raycasted = new Ray (transform.position, transform.forward);
			Physics.Raycast (raycasted, out hitInfo);
			transform.position = new Vector3 (hitInfo.point.x, hitInfo.point.y + 10f, hitInfo.point.z);
		}
	}

}
