using UnityEngine;
using System.Collections;

public class RivalAI : MonoBehaviour
{


    public Transform[] Waypoints;
    public float Speed;
    public int currentWayPoint;
    public bool doPatrol = true;
    public Vector3 Target;
    public Vector3 MoveDirection;
    public Vector3 Velocity;
   // public GameObject game;

    void Update()
    {


        if (currentWayPoint < Waypoints.Length)
        {
            Target = Waypoints[currentWayPoint].position;
            MoveDirection = Target - transform.position;
            Velocity = GetComponent<Rigidbody>().velocity;
            if (MoveDirection.magnitude < 1)
            {

                StartCoroutine("waitFiveSeconds");
                currentWayPoint++;

            }

            else
            {
                Velocity = MoveDirection.normalized * Speed;
            }
        }
        else
        {
            if (doPatrol)
            {
                currentWayPoint = 0;
            }
            else
            {
                Velocity = Vector3.zero;
            }
        }

        GetComponent<Rigidbody>().velocity = Velocity;
       // transform.LookAt(Target);

    }

    IEnumerator waitFiveSeconds()
    {
        Speed = 10;
        yield return new WaitForSeconds(0);

        Speed = 15;

    }

}
