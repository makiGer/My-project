using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Y : MonoBehaviour
{
    public Text point;
    public int Ay;

    // Start is called before the first frame update
    void Start()
    {
        Ay = 0;
        point = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        point.text = Ay.ToString();

    }

    public void increment()
    {
        if (Ay < 5)
        {
            Ay++;
        }
    }

    public void decrement()
    {
        if (Ay > 0)
        {
            Ay--;
        }
    }

}
