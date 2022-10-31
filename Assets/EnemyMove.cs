using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    [Tooltip("追いかける対象")]
    private GameObject player;

    private NavMeshAgent navMeshAgent;

    [SerializeField]
    private Vector3 initialPosition;
    private Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        setInitialPosition();
        gameObject.transform.position = initialPosition;

    }

    void OnEnable()
    {
        setInitialPosition();
    }

    public void OnDetectObject(Collider collider){
        if(collider.CompareTag("Player")){
            navMeshAgent.destination = collider.transform.position;
        }
    }

    public Quaternion getRotation(){
        return rotation;
    }

    /*
    // Update is called once per frame
    void Update()
    {
        navMeshAgent.destination = player.transform.position;  
    }
    */

    public void setInitialPosition(){
        gameObject.transform.position = initialPosition;
    }
}
