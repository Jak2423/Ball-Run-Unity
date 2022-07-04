using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other) {
      CollectControl.coinCount += 1;
      this.gameObject.SetActive(false);
    }
}