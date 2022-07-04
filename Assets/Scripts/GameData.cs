using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  [System.Serializable]

public class GameData
{
  public int levelUnlocked;
  public int totalCoin;

  public GameData() {
    levelUnlocked = 1;
  }
}
