using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelControl : MonoBehaviour
{
    public Text levelText;
    public static int level = 1;
    Vector3 level1Pos = new Vector3(0f, 1f, -24f);
    Vector3 level2Pos = new Vector3(20f, 1f, -24f);
    Vector3 level3Pos = new Vector3(40f, 1f, -24f);
    public GameObject ball;
    public GameObject level01;
    public GameObject level02;
    public GameObject level03;
    public GameData gameData;
    public static GameObject[] coins;


    void Update()
    {
      levelText.text = "Level " + level.ToString();
    }

    public void LevelLoad() {
      gameData = SavingGame.Load();
      level = gameData.levelUnlocked;
      CollectControl.coinCount = 0;

      if(level == 1) {
        coins = GameObject.FindGameObjectsWithTag("Coin");
        ball.transform.position = level1Pos;
      }

      if(level == 2) {
        level01.SetActive(false);
        level02.SetActive(true);
        coins = GameObject.FindGameObjectsWithTag("Coin");
        ball.transform.position = level2Pos;
      }
      if(level == 3) {
        level02.SetActive(false);
        level03.SetActive(true);
        coins = GameObject.FindGameObjectsWithTag("Coin");
        ball.transform.position = level3Pos;
      }

    }
}
