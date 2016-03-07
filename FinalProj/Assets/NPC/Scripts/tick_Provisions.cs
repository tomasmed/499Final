using UnityEngine;
using System.Collections;

public class tick_Provisions : MonoBehaviour {

    //Varaibles
    public float rate = 10; // The rate at which Provisions are sent to the destination
    public GameObject provision_prefab; //The prefab for the provision.
    public GameObject Destination; //The base to which Provisions aer being sent to.
    public bool is_source = true;
    public int team = 1;



    //Provision management variables
    public int max_provisions;
    private int current_provisions = 0;

    private Vector3 objective;
    private float counter;

    void Start()
    {
        counter = 0;
        objective = Destination.transform.position - gameObject.transform.position; // The destination at which we shoot the provisions
    }


	// Update is called once per frame
	void Update () {
        if (is_source)
        {
            if (counter > rate && ((current_provisions - GameController.S.team1_pts) < max_provisions) )
            {
                current_provisions++;
                counter = 0;

                GameObject provision = Instantiate(provision_prefab) as GameObject;
                provision.GetComponent<NavMeshAgent>().SetDestination(Destination.transform.position);
                provision.GetComponent<Provision>().team = team;
            }
            else counter += Random.Range(0.2f,1.6f);
        }
	}
}
