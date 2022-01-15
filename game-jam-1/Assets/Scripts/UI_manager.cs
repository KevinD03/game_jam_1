using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_manager : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;

    [SerializeField]
    private Text _leverText;


    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = "Score:" + 0;
        _leverText.text = "Lever: RIGHT";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void updateLever(bool Left)
    {
        if (Left)
        {
            _leverText.text = "Lever: Left";
        } else
        {
            _leverText.text = "Lever: Right";
        }
    }

    public void updateScore(int score)
    {
        _scoreText.text = "Score:" + score.ToString();
    }
}
