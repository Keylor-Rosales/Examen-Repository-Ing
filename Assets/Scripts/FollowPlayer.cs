using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	public Transform player;
	public Vector3 offset;
	public Image image1;

	void Update()
	{
		transform.position = player.position + offset;
	}

	/*
	public void ()
	{
		image.GetComponent<Image>().color = new Color32(255,255,225,100);
		image.GetComponent<Image>().color = new Color32(255,255,225,100);
	}
	*/
}
