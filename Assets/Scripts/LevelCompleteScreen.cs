using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelCompleteScreen : MonoBehaviour
{
  public LevelControl LevelControl;
  public GameData gameData;

  public void Setup() {
    gameObject.SetActive(true);
    Time.timeScale = 0;
  }

  public void NextLevelButton() {
    LevelControl.level++;
    gameData.levelUnlocked = LevelControl.level;
    SavingGame.Save(gameData);
    gameObject.SetActive(false);
    LevelControl.LevelLoad();
    Time.timeScale = 1;

  }
}
