using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{

    [SerializeField]
    GameManager gameManager = null;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")){
            gameManager.GameClear();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
