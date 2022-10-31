using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{


    public TextMeshProUGUI time;

    public float second;

    [SerializeField]
    GameManager gameManager = null;


    // Start is called before the first frame update
    void Start()
    {
        second = 120;
    }


    void OnEnable() {
        second = 60;
    }



    // Update is called once per frame
    void Update()
    {
        second -= Time.deltaTime;
        if(second <= 0)
        {
            gameManager.GameOver();
            gameObject.SetActive(false);
        }
        else
        {
            time.text = second.ToString("f1");        
        }
    }
}
