using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class followPlayer : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent = null;
    public Transform destination = null;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 20)
        {
            agent.SetDestination(destination.position);
        }
    }

}
