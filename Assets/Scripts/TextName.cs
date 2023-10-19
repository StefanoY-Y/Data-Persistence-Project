using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;

public class TextName : MonoBehaviour
{
    public Text nick2;
    
    //public MenuManager menuManager;
    // Start is called before the first frame update
    void Awake()
    {
        
        nick2.text = "Best Score: " + " " + MenuManager.Instance.nick.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
