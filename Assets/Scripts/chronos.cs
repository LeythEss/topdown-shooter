using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chronos : MonoBehaviour
{
    public float timer;
    public Text Timertext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Timertext.text = Mathf.Floor(timer).ToString();
    }
}
