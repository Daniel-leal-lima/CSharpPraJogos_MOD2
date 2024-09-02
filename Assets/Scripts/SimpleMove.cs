using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
	[SerializeField] float speed = 1;
	void Update()
	{
		if (Input.GetKey(KeyCode.A))
		{
			Translate(new Vector3(-CalculateRealSpeed(), 0f, 0f));
		}
		if (Input.GetKey(KeyCode.D))
		{
			Translate(new Vector3(CalculateRealSpeed(), 0f, 0f));
		}
		if (Input.GetKey(KeyCode.W))
		{
			Translate(new Vector3(0f, 0f, CalculateRealSpeed()));
		}
		if (Input.GetKey(KeyCode.S))
		{
			Translate(new Vector3(0f, 0f, -CalculateRealSpeed()));
		}
	}
	void Translate(Vector3 translate)
	{
		transform.position += translate;
	}
	float CalculateRealSpeed()
	{
		return speed / 100f;
	}
}
