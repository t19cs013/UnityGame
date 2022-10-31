using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    PlayerController player  = null;

    [SerializeField]
    EnemyMove enemy = null; 

    [SerializeField]
    Timer time = null;

    [SerializeField]
    Canvas gameStartCanvas = null;
    [SerializeField]
    Canvas gameOverCanvas = null;

    [SerializeField]
    Canvas gameClearCanvas = null;

    [SerializeField]
    DoorScript door = null;

    void Start()
    {
        player.gameObject.SetActive(false);
        time.gameObject.SetActive(false);
        enemy.gameObject.SetActive(false);
        gameOverCanvas.gameObject.SetActive(false);
        gameClearCanvas.gameObject.SetActive(false);

        gameStartCanvas.gameObject.SetActive(true);

    }

    public void GameStart()
    {
        gameStartCanvas.gameObject.SetActive(false);
        gameOverCanvas.gameObject.SetActive(false);
        gameClearCanvas.gameObject.SetActive(false);

        player.setInitialPosition();

        player.gameObject.SetActive(true);
        time.gameObject.SetActive(true);
        enemy.gameObject.SetActive(true);
        door.gameObject.SetActive(true);

    }


    public void GameOver()
{
    player.gameObject.SetActive(false);
    time.gameObject.SetActive(false);
    enemy.gameObject.SetActive(false);
    gameOverCanvas.gameObject.SetActive(true);

}

    public void GameClear(){
        player.gameObject.SetActive(false);
        time.gameObject.SetActive(false);
        enemy.gameObject.SetActive(false);
        door.gameObject.SetActive(false);
        gameClearCanvas.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
                
    }
}
