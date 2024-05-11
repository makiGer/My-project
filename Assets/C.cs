using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor.AnimatedValues;
using UnityEngine;
using UnityEngine.UI;

public class C : MonoBehaviour
{
    public X x;
    public Y y;

    public X Bx;
    public Y By;

    public Text c;
    public Text a;
    public Text b;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        int X = x.Ax +  Bx.Ax;
        int Y = y.Ay + By.Ay;

        int Cx = X * X;
        int Cy = Y * Y;

        float Cz = Cy + Cx;
        float CValue = Mathf.Sqrt(Cz);

        float AValue = Mathf.Sqrt((By.Ay * By.Ay) + (Bx.Ax * Bx.Ax));
        float BValue = Mathf.Sqrt((y.Ay * y.Ay) + (x.Ax * x.Ax));

        c.text = CValue.ToString();
        a.text = AValue.ToString();
        b.text = BValue.ToString();

        if (Y == 1)
        {
            this.transform.localScale = new Vector3(.2f, 1f);
            this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            if (X == 1)
            {
                this.transform.localScale = new Vector3(.27f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 45f);
            }
            else if (X == 2)
            {                
                this.transform.localScale = new Vector3(.44f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 24f);
            }
            else if (X == 3)
            {               
                this.transform.localScale = new Vector3(.62f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 16f);
            }
            else if (X == 4)
            {               
                this.transform.localScale = new Vector3(.82f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 12f);
            }
            else if (X == 5)
            {               
                this.transform.localScale = new Vector3(1.01f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 10f);
            }
            else if (X == 6)
            {
                this.transform.localScale = new Vector3(1.18f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 8f);
            }
            else if (X == 7)
            {
                this.transform.localScale = new Vector3(1.37f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 7f);
            }
            else if (X == 8)
            {
                this.transform.localScale = new Vector3(1.55f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 6.5f);
            }
            else if (X == 9)
            {
                this.transform.localScale = new Vector3(1.77f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 5.75f);
            }
            else if (X == 10)
            {
                this.transform.localScale = new Vector3(1.97f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 5f);
            }
        }
        else if (Y == 2)
        {
            this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            if (X == 1)
            {
                this.transform.localScale = new Vector3(.44f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 65f);
            }
            else if (X == 2)
            {
                this.transform.localScale = new Vector3(.55f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 45f);
            }
            else if (X == 3)
            {
                this.transform.localScale = new Vector3(.7f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 32.5f);
            }
            else if (X == 4)
            {
                this.transform.localScale = new Vector3(.88f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 25.5f);
            }
            else if (X   == 5)
            {
                this.transform.localScale = new Vector3(1.07f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 21f);
            }
            else if (X == 6)
            {
                this.transform.localScale = new Vector3(1.24f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 17.5f); 
            }
            else if (X == 7)
            {
                this.transform.localScale = new Vector3(1.42f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 15f);
            }
            else if (X == 8)
            {
                this.transform.localScale = new Vector3(1.6f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 13.5f);
            }
            else if (X   == 9)
            {
                this.transform.localScale = new Vector3(1.8f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 12f);
            }
            else if (X == 10)
            {
                this.transform.localScale = new Vector3(2f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 10.5f);
            }
        }
        else if (Y == 3)
        {
            this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            if (X == 1)
            {
                this.transform.localScale = new Vector3(.62f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 72.5f);
            }
            else if (X == 2)
            {
                this.transform.localScale = new Vector3(.7f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 56.5f);
            }
            else if (X == 3)
            {
                this.transform.localScale = new Vector3(.83f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 45f);
            }
            else if (X == 4)
            {
                this.transform.localScale = new Vector3(1f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 36f);
            }
            else if (X == 5)
            {
                this.transform.localScale = new Vector3(1.15f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 30.5f);
            }
            else if (X == 6)
            {
                this.transform.localScale = new Vector3(1.3f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 26f);
            }
            else if (X == 7)
            {
                this.transform.localScale = new Vector3(1.5f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 22.5f);
            }
            else if (X == 8)
            {
                this.transform.localScale = new Vector3(1.67f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 20f);
            }
            else if (X == 9)
            {
                this.transform.localScale = new Vector3(1.85f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 18f);
            }
            else if (X == 10)
            {
                this.transform.localScale = new Vector3(2.05f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 16.25f);
            }
        }
        else if (Y == 4)
        {
            this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            if (X == 1)
            {
                this.transform.localScale = new Vector3(.82f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 77f);
            }
            else if (X == 2)
            {
                this.transform.localScale = new Vector3(.88f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 64f);
            }
            else if (X == 3)
            {
                this.transform.localScale = new Vector3(1f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 53f);
            }
            else if (X == 4)
            {
                this.transform.localScale = new Vector3(1.12f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 45f);
            }
            else if (X == 5)
            {
                this.transform.localScale = new Vector3(1.26f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 38.5f);
            }
            else if (X == 6)
            {
                this.transform.localScale = new Vector3(1.4f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 33.5f);
            }
            else if (X == 7)
            {
                this.transform.localScale = new Vector3(1.56f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 29.5f);
            }
            else if (X == 8)
            {
                this.transform.localScale = new Vector3(1.74f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 26.5f);
            }
            else if (X == 9)
            {
                this.transform.localScale = new Vector3(1.92f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 23.5f);
            }
            else if (X == 10)
            {
                this.transform.localScale = new Vector3(2.1f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 21.5f);
            }
        }
        else if (Y == 5)
        {
            this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            if (X == 1)
            {
                this.transform.localScale = new Vector3(1.0f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 79.5f);
            }
            else if (X == 2)
            {
                this.transform.localScale = new Vector3(1.07f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 68.5f);
            }
            else if (X == 3)
            {
                this.transform.localScale = new Vector3(1.15f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 59.5f);
            }
            else if (X == 4)
            {
                this.transform.localScale = new Vector3(1.26f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 51.5f);
            }
            else if (X == 5)
            {
                this.transform.localScale = new Vector3(1.39f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 45f);
            }
            else if (X == 6)
            {
                this.transform.localScale = new Vector3(1.5f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 40f);
            }
            else if (X == 7)
            {
                this.transform.localScale = new Vector3(1.67f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 35.5f);
            }
            else if (X == 8)
            {
                this.transform.localScale = new Vector3(1.8f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 32f);
            }
            else if (X == 9)
            {
                this.transform.localScale = new Vector3(2f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 29f);
            }
            else if (X == 10)
            {
                this.transform.localScale = new Vector3(2.18f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 26.5f);
            }
        }
        else if (Y == 6)
        {
            this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            if (X == 1)
            {
                this.transform.localScale = new Vector3(1.18f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 81.5f);
            }
            else if (X == 2)
            {
                this.transform.localScale = new Vector3(1.24f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 72f);
            }
            else if (X == 3)
            {
                this.transform.localScale = new Vector3(1.3f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 64f);
            }
            else if (X == 4)
            {
                this.transform.localScale = new Vector3(1.4f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 65.5f);
            }
            else if (X == 5)
            {
                this.transform.localScale = new Vector3(1.5f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 50f);
            }
            else if (X == 6)
            {
                this.transform.localScale = new Vector3(1.65f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 45f);
            }
            else if (X == 7)
            {
                this.transform.localScale = new Vector3(1.8f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 40.5f);
            }
            else if (X == 8)
            {
                this.transform.localScale = new Vector3(1.96f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 37);
            }
            else if (X == 9)
            {
                this.transform.localScale = new Vector3(2.12f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 33.5f);
            }
            else if (X == 10)
            {
                this.transform.localScale = new Vector3(2.27f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f,30.5f);
            }
        }
        else if (Y == 7)
        {
            this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            if (X == 1)
            {
                this.transform.localScale = new Vector3(1.37f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 82.5f);
            }
            else if (X == 2)
            {
                this.transform.localScale = new Vector3(1.42f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 74.5f);
            }
            else if (X == 3)
            {
                this.transform.localScale = new Vector3(1.5f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 67f);
            }
            else if (X == 4)
            {
                this.transform.localScale = new Vector3(1.56f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 60.5f);
            }
            else if (X == 5)
            {
                this.transform.localScale = new Vector3(1.67f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 55f);
            }
            else if (X == 6)
            {
                this.transform.localScale = new Vector3(1.8f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 49.5f);
            }
            else if (X == 7)
            {
                this.transform.localScale = new Vector3(1.93f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 45f);
            }
            else if (X == 8)
            {
                this.transform.localScale = new Vector3(2.1f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 41f);
            }
            else if (X == 9)
            {
                this.transform.localScale = new Vector3(2.24f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 38f);
            }
            else if (X == 10)
            {
                this.transform.localScale = new Vector3(2.4f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 35f);
            }
        }
        else if (Y == 8)
        {
            this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            if (X == 1)
            {
                this.transform.localScale = new Vector3(1.55f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 83.5f);
            }
            else if (X == 2)
            {
                this.transform.localScale = new Vector3(1.6f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 76.5f);
            }
            else if (X == 3)
            {
                this.transform.localScale = new Vector3(1.67f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 70f);
            }
            else if (Y == 4)
            {
                this.transform.localScale = new Vector3(1.74f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 63.5f);
            }
            else if (X == 5)
            {
                this.transform.localScale = new Vector3(1.8f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 58.5f);
            }
            else if (X == 6)
            {
                this.transform.localScale = new Vector3(1.96f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 53.5f);
            }
            else if (X == 7)
            {
                this.transform.localScale = new Vector3(2.08f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 49f);
            }
            else if (X == 8)
            {
                this.transform.localScale = new Vector3(2.21f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 45f);
            }
            else if (X == 9)
            {
                this.transform.localScale = new Vector3(2.36f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 41.5f);
            }
            else if (X == 10)
            {
                this.transform.localScale = new Vector3(2.5f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 38.75f);
            }
        }
        else if (Y == 9)
        {
            this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            if (X == 1)
            {
                this.transform.localScale = new Vector3(1.77f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 84.5f);
            }
            else if (X == 2)
            {
                this.transform.localScale = new Vector3(1.8f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 78f);
            }
            else if (X == 3)
            {
                this.transform.localScale = new Vector3(1.85f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 72f);
            }
            else if (X == 4)
            {
                this.transform.localScale = new Vector3(1.92f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 66.5f);
            }
            else if (X == 5)
            {
                this.transform.localScale = new Vector3(2f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 61.25f);
            }
            else if (X == 6)
            {
                this.transform.localScale = new Vector3(2.11f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 56.5f);
            }
            else if (X == 7)
            {
                this.transform.localScale = new Vector3(2.24f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 52.5f);
            }
            else if (X == 8)
            {
                this.transform.localScale = new Vector3(2.36f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 48.5f);
            }
            else if (X == 9)
            {
                this.transform.localScale = new Vector3(2.48f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 45f);
            }
            else if (X == 10)
            {
                this.transform.localScale = new Vector3(2.63f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 42f);
            }
        }
        else if (Y == 10)
        {
            this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            if (X == 1)
            {
                this.transform.localScale = new Vector3(1.97f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 85f);
            }
            else if (X == 2)
            {
                this.transform.localScale = new Vector3(2f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 79f);
            }
            else if (X == 3)
            {
                this.transform.localScale = new Vector3(2.03f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 73.5f);
            }
            else if (X == 4)
            {
                this.transform.localScale = new Vector3(2.1f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 68.5f);
            }
            else if (X == 5)
            {
                this.transform.localScale = new Vector3(2.18f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 64f);
            }
            else if (X == 6)
            {
                this.transform.localScale = new Vector3(2.29f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 59.5f);
            }
            else if (X == 7)
            {
                this.transform.localScale = new Vector3(2.38f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 55.5f);
            }
            else if (X == 8)
            {
                this.transform.localScale = new Vector3(2.5f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 51.5f);
            }
            else if (X == 9)
            {
                this.transform.localScale = new Vector3(2.63f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 48f);
            }
            else if (X == 10)
            {
                this.transform.localScale = new Vector3(12.75f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 45f);
            }
        }

    }
}

