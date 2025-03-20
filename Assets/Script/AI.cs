using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform player; 

    [SerializeField] private float stoppingDistance = 1.0f;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.stoppingDistance = stoppingDistance;
    }

    void Update()
    {
        if (player == null)
        {
            Debug.LogWarning("please assing the player");
            return;
        }
        agent.SetDestination(player.position);

    
        if (agent.remainingDistance <= stoppingDistance && !agent.pathPending)
        {
            agent.velocity = Vector3.zero; 
            agent.isStopped = true;
        }
        else
        {
            agent.isStopped = false;
        }
    }
}
