using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerSpeed : MonoBehaviour
{
    public PlayerMovement pm;
    public Text speedText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speedText.text = "Speed: " + pm.GetComponent<Rigidbody>().velocity.magnitude;
    }
}
