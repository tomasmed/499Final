using UnityEngine;
using System.Collections;

public class Provision : MonoBehaviour {
    public int team;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Objective")
        {
            if (team == 1)
            {
                GameController.S.team1_pts++;
            }
            else if (team == 2)
            {
                GameController.S.team_2pts++;
            }
            Debug.Log("Found target");
            Destroy(this.gameObject);
        }
    }

}
