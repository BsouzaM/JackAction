using UnityEngine;
using UnityEngine.AI;

// Player movement: When I hold my mouse1 button (ID 0) to some location, the player find the best way to get there.

public class MS_PlayerMove : MonoBehaviour
{
    public Camera MS_Camera;
    public NavMeshAgent MS_NavMeshAgent;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = MS_Camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                MS_NavMeshAgent.SetDestination(hit.point);
            }

        }
    }
}