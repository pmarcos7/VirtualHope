using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
public class DESGOSTOSO : MonoBehaviour
{
    // Start is called before the first frame update
 
    public UDPReceive udpReceive;
    public Text texto;
    
    void Start()
    {
        texto.enabled = false;

    }
 
    // Update is called once per frame
    void Update()
    {
 
        string data = udpReceive.data;
        if(data == "1")
        {
            texto.enabled = true;
        }
        else
        {
            texto.enabled = false;
        }
    }
}