﻿using UnityEngine;
using System.Collections;

public class Attacking : MonoBehaviour
{
	private Dinosaur me;
	private bool attack_is_cooling_down;
	private float attack_timer;
	
	void Start ()
	{
		me = gameObject.GetComponent<DinosaurObjectGetter> ().dinosaur ();
		attack_is_cooling_down = false;
		attack_timer = 0;
	}

	void Update ()
	{
		if (me.Is_Alive ()) {
			if (attack_is_cooling_down) {
				attack_timer += Time.deltaTime;
				if (attack_timer > me._AttackSpeed ()) {
					attack_timer = 0f;
					attack_is_cooling_down = false;
				}
			} else {
				int layer = 1 << 8; //Dinosaur is layer 8
				Collider[] colliders = Physics.OverlapSphere (gameObject.transform.position, me.Attack_Radius (), layer);
				foreach (Collider c in colliders) {
					if (c.gameObject != gameObject) {
						var getter = c.gameObject.GetComponent<DinosaurObjectGetter> ();
						if (getter != null) {
							Dinosaur enemy = getter.dinosaur ();
							if (enemy != null && enemy.Is_Alive ()) {
								if (me.Attack (enemy)) {
									attack_is_cooling_down = true;
									var ani = gameObject.GetComponentInChildren<Animation> ();
									if (ani != null) {
										ani.Play ("Attack0" + (Random.Range (0, 2) + 1).ToString ());
									}
									break;
								}
							}
						}
					}
				}
			}
		}
	}
}
