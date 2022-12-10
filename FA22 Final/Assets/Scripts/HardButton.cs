using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardButton : MonoBehaviour
{
    public Material[] material;

    public GameObject hardButton;

    public MenuController introbook;

    [SerializeField] AudioSource selectTone;
    [SerializeField] AudioSource selectClick;

    public void OnMouseDown()
    {
        hardButton.GetComponent<Renderer>().material = material[1];
        
        introbook.LookUp();
        
        selectTone.Play();
        selectClick.Play();
        
        Invoke("HardPath", 2f);
    }

    public void HardPath()
    {
        SceneManager.LoadScene("Scenes/HardMode/SceneHbegin");
    }
}
