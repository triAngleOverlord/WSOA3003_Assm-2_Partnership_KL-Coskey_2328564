using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance;

    [SerializeField] private GameObject titleCard;
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

        StartCoroutine(titleCardOff());
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

    public void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public IEnumerator titleCardOff()
    {
        yield return new WaitForSeconds(3);
        titleCard.SetActive(false);
    }
}
