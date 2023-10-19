using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class activateOnStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // enable
        GetComponent<TextMeshProUGUI>().enabled = true;        
    }

}
