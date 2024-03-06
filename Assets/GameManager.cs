using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance;

    public GameObject[] levels = new GameObject[] { };
    public int currentLevel = 0;

    public void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        //levels = GameObject.FindGameObjectsWithTag("Level");
        foreach (var level in levels)
        {
            level.SetActive(false);
        }
        levels[0].SetActive(true);
    }
    public void loading()
    {
        levels[currentLevel].SetActive(false);
        currentLevel += 1;
        StartCoroutine(loadNextLevel());
    }
    public IEnumerator loadNextLevel()
    {
        yield return new WaitForSecondsRealtime(3);
        levels[currentLevel].SetActive(true);
    }
}
