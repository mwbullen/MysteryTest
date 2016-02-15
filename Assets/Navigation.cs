using UnityEngine;
using System.Collections;

public class Navigation : MonoBehaviour {

    

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void NavtoGameObject(GameObject target) {
        NavMeshAgent navAgent = GetComponent<NavMeshAgent>();

        navAgent.SetDestination (target.transform.position);

	}

	public void NavtoGameObject(GameObject target, bool updateRotationBool) {
		NavMeshAgent navAgent = GetComponent<NavMeshAgent>();

		navAgent.SetDestination (target.transform.position);

		navAgent.updateRotation = updateRotationBool;
	}

    public void StopNavigation()
    {
        NavMeshAgent navAgent = GetComponent<NavMeshAgent>();
        navAgent.Stop();        
    }

    public void ResumeNavigation()
    {
        NavMeshAgent navAgent = GetComponent<NavMeshAgent>();
        navAgent.Resume();
    }

	public bool NavisComplete() {
		NavMeshAgent navAgent = GetComponent<NavMeshAgent>();

		if (navAgent.pathPending)
			return false;
		
		return (navAgent.remainingDistance < 1);
	}
}
