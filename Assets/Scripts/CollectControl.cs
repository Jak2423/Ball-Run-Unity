using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectControl : MonoBehaviour
{
    public static int coinCount;
    public Text coinCountDisplay;
    public LevelControl LevelControl;

    // Update is called once per frame
    void Update()
    {
      coinCountDisplay.GetComponent<Text>().text = "" + coinCount;
    }

    public void LoadCoin() {
      foreach (GameObject coin in LevelControl.coins)
      {
        coin.SetActive(true);
      }
    }
}
