using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
  public Text coinText;
  public GameData gameData;
  public LevelControl LevelControl;


  public void Setup(int coin) {
    gameObject.SetActive(true);
    coinText.text = coin.ToString() + " COINS";
    Time.timeScale = 0;
  }

  public void RestartButton() {
    gameData = SavingGame.Load();
    LevelControl.level = gameData.levelUnlocked;
    CollectControl.coinCount = 0;
    LevelControl.LevelLoad();
    gameObject.SetActive(false);
    Time.timeScale = 1;
  }


}
