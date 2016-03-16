using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class FlyGuy : MonoBehaviour {

    Vector3 vel = Vector3.zero;
    int neighborCount = 0;
    ArrayList neighbors = new ArrayList();


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public Vector3 computeAlignment() {
        foreach(FlyGuy agent in neighbors)
        {
            if (agent != this.GetComponent<FlyGuy>())
            {
                if (Mathf.Abs(Vector3.Distance(agent.transform.position, this.transform.position)) < 10f)
                {
                    vel.x += agent.GetComponent<Rigidbody>().velocity.x;
                    vel.y += agent.GetComponent<Rigidbody>().velocity.y;
                    vel.z += agent.GetComponent<Rigidbody>().velocity.z;
                    neighborCount++;
                }

            }

        }

        if (neighborCount == 0) { return vel; }

        return Vector3.zero; //lmao

    }

}
