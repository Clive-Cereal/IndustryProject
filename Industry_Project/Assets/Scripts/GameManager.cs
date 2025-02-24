using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public static int PCCount;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this);

        Init();
    }

    void Init()
    {

        Cursor.visible = false;
        
        if (SceneManager.GetActiveScene().name != "Scene01")
        {
            SceneManager.LoadScene("Scene01");
        }
    }

    void Start()
    {
        PCCount = 0;
    }
}
