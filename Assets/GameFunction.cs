using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFunction : MonoBehaviour
{
    public GameObject Emeny;
    public float time;

    public Text ScoreText;
    public int Score = 0;
    public static GameFunction Instance;

    public GameObject GameOverTitle;
    public GameObject PlayButton;
    public bool IsPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        GameOverTitle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 0.1f && IsPlaying == true)
        {
            Vector3 pos = new Vector3(Random.Range(-10f, 10f), 4.5f, 0);
            Instantiate(Emeny, pos, transform.rotation);
            time = 0f;
        }
    }

    public void AddScore()
    {
        Score += 10;
        ScoreText.text = "Score: " + Score;
    }
    public void GameStart()
    {
        IsPlaying = true;
        GameOverTitle.SetActive(false);
        PlayButton.SetActive(false);
    }
    public void GameOver()
    {
        IsPlaying = false;
        GameOverTitle.SetActive(true);
    }
}
