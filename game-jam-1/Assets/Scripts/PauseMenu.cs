using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameObject pauseMenuUI;

    [SerializeField]
    private bool isPause;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            isPause = !isPause;
        }

        if (isPause)
        {
            Time.timeScale = 0;
            pauseMenuUI.SetActive(true);
        }
        else {
            Time.timeScale = 1;
            pauseMenuUI.SetActive(false);
        }
    }
}
