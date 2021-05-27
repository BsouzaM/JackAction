using UnityEngine;
using UnityEngine.AI;

// Player movement: When I hold my mouse1 button (ID 0) to some location, the player find the best way to get there.

public class NavMeshMovement : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent navmeshagent;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                navmeshagent.SetDestination(hit.point);
            }

        }
    }
}