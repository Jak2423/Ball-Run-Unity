using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameData gameData;
    public LevelControl LevelControl;

    void Start()
    {
      gameData = SavingGame.Load();
      LevelControl.level = gameData.levelUnlocked;
      CollectControl.coinCount = gameData.totalCoin;
      LevelControl.LevelLoad();
    }

    void Awake() {
      gameData = SavingGame.Load();
      LevelControl.level = gameData.levelUnlocked;
      CollectControl.coinCount = gameData.totalCoin;
      LevelControl.LevelLoad();
    }

    void OnApplicationQuit() {
      gameData.levelUnlocked = LevelControl.level;
      gameData.totalCoin = CollectControl.coinCount ;
      SavingGame.Save(gameData);
    }

    private void OnApplicationPause(bool pause)
    {
        if (pause)
        {
          gameData.levelUnlocked = LevelControl.level;
          gameData.totalCoin = CollectControl.coinCount ;
          SavingGame.Save(gameData);
        }

        else
        {
          gameData = SavingGame.Load();
          LevelControl.level = gameData.levelUnlocked;
          CollectControl.coinCount = gameData.totalCoin;
          LevelControl.LevelLoad();
        }
    }
    private void OnApplicationFocus(bool focus)
    {
        if (!focus)
        {
          gameData.levelUnlocked = LevelControl.level;
          gameData.totalCoin = CollectControl.coinCount ;
          SavingGame.Save(gameData);
        }
        else
        {
          gameData = SavingGame.Load();
          LevelControl.level = gameData.levelUnlocked;
          CollectControl.coinCount = gameData.totalCoin;
          LevelControl.LevelLoad();
        }
    }


}
