using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    public Text time;
    public Text kroki;
    // Start is called before the first frame update
    void Start()
    {
        kroki.text = "Kroki: " + PlayerPrefs.GetInt("Kroki").ToString();
        time.text = "Time: "+PlayerPrefs.GetFloat("Timer").ToString();
    }

    // Update is called once per frame
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
