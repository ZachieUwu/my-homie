using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform pointA, pointB, playerPos;
    public Transform currentTarget;
    

    public float chaseRange;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //agent.speed = 0;
        //EnemyPatrol();
    }

    // Update is called once per frame
    void Update()
    {
        //float distanceToPlayer = Vector3.Distance(transform.position, playerPos.position);
        //if (distanceToPlayer <= chaseRange)
        //{
        //    //detect player
        //    agent.speed = 10;
        //    agent.SetDestination(playerPos.position);
        //}
        //else
        //{
        //    //Distance = float
        //    //Path Pending = bool
        //    //Velocity = float
        //    if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
        //    {
        //        //Switch Target
        //        currentTarget = (currentTarget == pointA) ? pointB : pointA;
        //        agent.SetDestination(currentTarget.position);
        //    }
        //}
    }

    //public async void EnemyPatrol()
    //{
    //    await Task.Delay(5000);
    //    agent.speed = 3.5f;
    //    agent.SetDestination(pointA.position);
        
    //}

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
