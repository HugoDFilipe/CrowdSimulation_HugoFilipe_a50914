using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour {

    GameObject [] goallocations;
    NavMeshAgent agent;
    Animator anim;

    void Start() {

        agent = GetComponent<NavMeshAgent>();
        goallocations = GameObject.FindGameObjectsWithTag("goal");
        int i = Random.Range(0, goallocations.Length);
        agent.SetDestination(goallocations[i].transform.position);
        anim = this.GetComponent<Animator>();
        anim.SetTrigger("isWalking");
    }


    void Update() {
        if (agent.remainingDistance < 1)
        {
            int i = Random.Range(0, goallocations.Length);
            agent.SetDestination(goallocations[i].transform.position);
        }
    }
}