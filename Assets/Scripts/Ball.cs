using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public float speed = 8f;
    Vector3 lastMousePos;
    public GameOverScreen GameOverScreen;
    public LevelCompleteScreen LevelCompleteScreen;
    public GameData gameData;
    private float lastMousePoint;
    public CollectControl CollectControl;


    void OnMouseDown()
    {
      lastMousePoint = Input.mousePosition.x;
    }

    void OnMouseDrag()
    {
      float difference = Input.mousePosition.x - lastMousePoint;
      transform.position = new Vector3(transform.position.x + (difference / 60), transform.position.y, transform.position.z);
      lastMousePoint = Input.mousePosition.x;
    }

    void FixedUpdate()
    {
      transform.Translate(Vector3.forward * speed * Time.deltaTime);
      if(transform.position.y < -5) {
        Die();
      }
    }

    public void Die() {
      gameData.levelUnlocked = LevelControl.level;
      SavingGame.Save(gameData);
      GameOverScreen.Setup(CollectControl.coinCount);
      CollectControl.LoadCoin();
    }

    private void OnCollisionEnter(Collision collision) {
      if(collision.gameObject.tag == "Enemy"){
        Die();
      }

       if(collision.gameObject.tag == "Finish") {
        if(gameData.levelUnlocked == 3) {
          gameData.levelUnlocked = 1;
          SavingGame.Save(gameData);
          Scene scene = SceneManager.GetActiveScene();
          SceneManager.LoadScene(scene.name);
        }
        else {
          LevelCompleteScreen.Setup();
        }

      }
    }
}
