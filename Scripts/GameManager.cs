using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject endPanel;
    private GameObject[] allBoxes;
    // Start is called before the first frame update
    private void Update()
    {
        allBoxes = GameObject.FindGameObjectsWithTag("Box");
        if(allBoxes.Length == 0)
        {
            endPanel.SetActive(true);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
