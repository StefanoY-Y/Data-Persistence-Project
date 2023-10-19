using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public TMP_InputField inputName;
    public TMP_Text nick;
    public TMP_Text scoreMenu;
   
    
    // Start is called before the first frame update
    private void Awake()
    {
        // start of new code

        if (Instance != null)
        {
            
            Destroy(gameObject);
            
            return;
        }
        
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
        //nick.text = Instance.inputName.text;
    }

   
    
}
