using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrolState : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NavMeshAgent agent = animator.GetComponent<NavMeshAgent>();
        AI enemy = agent.GetComponent<AI>();
        agent.speed = 3.5f;
        agent.SetDestination(enemy.pointA.position);

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NavMeshAgent agent = animator.GetComponent<NavMeshAgent>();
        AI enemy = agent.GetComponent<AI>();


        if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
        {
            //Switch Target
            enemy.currentTarget = (enemy.currentTarget == enemy.pointA) ? enemy.pointB : enemy.pointA;
            agent.SetDestination(enemy.currentTarget.position);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
