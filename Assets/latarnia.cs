using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class latarnia : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(1);
            PlayerPrefs.SetInt("Kroki", other.GetComponent<MenelMovement>().kroczki);
            PlayerPrefs.SetFloat("Timer", other.GetComponent<MenelMovement>().time);
        }
    }
}
