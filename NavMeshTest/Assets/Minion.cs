using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum MinionTeam:byte
{
    RED = 0,BLUE
}
public enum MinionLane : byte
{
    TOP = 0,MID,BOT
}
public class Minion : MonoBehaviour {

    public MinionTeam Team;
    public MinionLane Lane;

    NavMeshAgent agent;

    // Use this for initialization
    void Start() {
        this.agent = this.GetComponent<NavMeshAgent>();
    }
	// Update is called once per frame
	void Update () {
		
	}
}
