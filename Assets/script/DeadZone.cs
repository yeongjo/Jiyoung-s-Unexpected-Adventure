﻿using UnityEngine;
using System.Collections;

public class DeadZone : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D coll)
	{
		if(coll.gameObject.name == "Player")
		{
			coll.GetComponent<Player> ().Die ();
		}
	}
}

