using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider col)
    {
        HealthBarScript.health -= 10f;
		
	}
}
