using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public Canvas deathScreen;
    public Button restartButton;

    void Start () {
        restartButton = restartButton.GetComponent<Button>();
        restartButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick(){
        deathScreen.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
