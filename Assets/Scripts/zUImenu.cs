using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zUImenu : MonoBehaviour
{
    public TMP_InputField inputName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
       
    }
    public void ExitNew()
    {
        SceneManager.LoadScene(0);
        
    }
    public void NewName()
    {
        // add code here to handle when a color is selected
        MenuManager.Instance.nick.text = inputName.text;
        // nick.text = inputName.text;
        Debug.Log(MenuManager.Instance.nick.text);
    }
   

}
