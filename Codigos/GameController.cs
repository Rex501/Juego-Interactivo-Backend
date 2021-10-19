using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public GameObject gameOverText;
    public bool gameOver;


    private void Awake()
    {
        if(GameController.instance == null)
        {
            GameController.instance = this;
        }
        else if (GameController.instance != this)
        {
            Destroy(gameObject);
            Debug.LogWarning("GameController ha sido instanciado por segunda vez esto no deberia pasar");
        }
        
    }

    //Use this initialization
    void Star(){

    }

    //Use is called once per frame
    void Update(){
        if(gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    public void BirdDie()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }

    private void onDestroy()
    {
        if(GameController.instance == this)
        {
            GameController.instance = null;
        }
    }
}
