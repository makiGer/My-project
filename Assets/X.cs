using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class X : MonoBehaviour
{
    public Text point;
    public int Ax;

    // Start is called before the first frame update
    void Start()
    {
        Ax = 5;
        point = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        point.text = Ax.ToString();

    }

    public void increment()
    {
        if (Ax < 5)
        {
            Ax++;
        }
    }

    public void decrement()
    {
        if (Ax > 0)
        {
            Ax--;
        }
    }

}
