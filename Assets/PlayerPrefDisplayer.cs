using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefDisplayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string key;
    public Text HighscoreText;

    void Start()
    {
        int mynumber= PlayerPrefs.GetInt(key);
        Debug.Log(mynumber);
        HighscoreText.text = mynumber.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
