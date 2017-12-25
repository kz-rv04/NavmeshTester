using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum MinionType:byte
{
    RED = 0,BLUE
}
public class Minion : MonoBehaviour {
    
    
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        this.agent = this.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
