using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameControl : MonoBehaviour
{

    public static GameControl instance;
    public bool gameOver = false;

    public GameObject goText;

    public Text scoreText;
    public int score = 0;
    


    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }


    public void BirdDied()
    {
        gameOver = true;
        Debug.Log("Yes. Bird has controll here");
        goText.SetActive(true);

    }
    public void BirdScored()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && gameOver == true)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    
}
