using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour
{
    public X x;
    public Y y;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (y.Ay == 1)
        {
            this.transform.localScale = new Vector3(.2f, 1f);

            if (x.Ax == 1)
            {
                this.transform.localScale = new Vector3(.27f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 45f);
            }
            else if (x.Ax == 2)
            {
                this.transform.localScale = new Vector3(.44f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 27f);
            }
            else if (x.Ax == 3)
            {
                this.transform.localScale = new Vector3(.62f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 19f);
            }
            else if (x.Ax == 4)
            {
                this.transform.localScale = new Vector3(.82f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 14.5f);
            }
            else if (x.Ax == 5)
            {
                this.transform.localScale = new Vector3(1.01f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 11.5f);
            }
            else if (x.Ax == 0)
            {
                this.transform.localScale = new Vector3(.2f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            }



            if (x.Ax == -1)
            {
                this.transform.localScale = new Vector3(.27f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 135f);
            }
            else if (x.Ax == -2)
            {
                this.transform.localScale = new Vector3(.45f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 153f);
            }
            else if (x.Ax == -3)
            {
                this.transform.localScale = new Vector3(.62f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 161f);
            }
            else if (x.Ax == -4)
            {
                this.transform.localScale = new Vector3(.82f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 165.5f);
            }
            else if (x.Ax == -5)
            {
                this.transform.localScale = new Vector3(1.02f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 168.5f);
            }
            else if (x.Ax == 0)
            {
                this.transform.localScale = new Vector3(.2f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            }
        }
        else if (y.Ay == 2)
        {
            this.transform.localScale = new Vector3(.4f, 1f);

            if (x.Ax == 1)
            {
                this.transform.localScale = new Vector3(.44f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 65f);
            }
            else if (x.Ax == 2)
            {
                this.transform.localScale = new Vector3(.55f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 45f);
            }
            else if (x.Ax == 3)
            {
                this.transform.localScale = new Vector3(.7f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 34f);
            }
            else if (x.Ax == 4)
            {
                this.transform.localScale = new Vector3(.88f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 27f);
            }
            else if (x.Ax == 5)
            {
                this.transform.localScale = new Vector3(1.07f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 22f);
            }
            else if (x.Ax == 0)
            {
                this.transform.localScale = new Vector3(.4f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            }


            if (x.Ax == -1)
            {
                this.transform.localScale = new Vector3(.44f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 115f);
            }
            else if (x.Ax == -2)
            {
                this.transform.localScale = new Vector3(.55f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 135f);
            }
            else if (x.Ax == -3)
            {
                this.transform.localScale = new Vector3(.7f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 146f);
            }
            else if (x.Ax == -4)
            {
                this.transform.localScale = new Vector3(.88f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 153f);
            }
            else if (x.Ax == -5)
            {
                this.transform.localScale = new Vector3(1.07f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 158f);
            }
            else if (x.Ax == 0)
            {
                this.transform.localScale = new Vector3(.4f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            }
        }

        else if (y.Ay == 3)
        {
            this.transform.localScale = new Vector3(.6f, 1f);

            if (x.Ax == 1)
            {
                this.transform.localScale = new Vector3(.62f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 72f);
            }
            else if (x.Ax == 2)
            {
                this.transform.localScale = new Vector3(.7f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 57f);
            }
            else if (x.Ax == 3)
            {
                this.transform.localScale = new Vector3(.83f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 45f);
            }
            else if (x.Ax == 4)
            {
                this.transform.localScale = new Vector3(1f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 37f);
            }
            else if (x.Ax == 5)
            {
                this.transform.localScale = new Vector3(1.15f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 31f);
            }
            else if (x.Ax == 0)
            {
                this.transform.localScale = new Vector3(.6f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            }


            if (x.Ax == -1)
            {
                this.transform.localScale = new Vector3(.62f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 108f);
            }
            else if (x.Ax == -2)
            {
                this.transform.localScale = new Vector3(.7f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 123f);
            }
            else if (x.Ax == -3)
            {
                this.transform.localScale = new Vector3(.83f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 135f);
            }
            else if (x.Ax == -4)
            {
                this.transform.localScale = new Vector3(1f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 143f);
            }
            else if (x.Ax == -5)
            {
                this.transform.localScale = new Vector3(1.15f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 149f);
            }
            else if (x.Ax == 0)
            {
                this.transform.localScale = new Vector3(.6f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            }
        }

        else if (y.Ay == 4)
        {
            this.transform.localScale = new Vector3(.8f, 1f);

            if (x.Ax == 1)
            {
                this.transform.localScale = new Vector3(.82f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 77f);
            }
            else if (x.Ax == 2)
            {
                this.transform.localScale = new Vector3(.88f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 64f);
            }
            else if (x.Ax == 3)
            {
                this.transform.localScale = new Vector3(1f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 53.5f);
            }
            else if (x.Ax == 4)
            {
                this.transform.localScale = new Vector3(1.12f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 45f);
            }
            else if (x.Ax == 5)
            {
                this.transform.localScale = new Vector3(1.26f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 39.5f);
            }
            else if (x.Ax == 0)
            {
                this.transform.localScale = new Vector3(.8f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f,90f);
            }


            if (x.Ax == -1)
            {
                this.transform.localScale = new Vector3(.82f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 103f);
            }
            else if (x.Ax == -2)
            {
                this.transform.localScale = new Vector3(.88f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 116f);
            }
            else if (x.Ax == -3)
            {
                this.transform.localScale = new Vector3(1.0f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 126.5f);
            }
            else if (x.Ax == -4)
            {
                this.transform.localScale = new Vector3(1.12f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 135f);
            }
            else if (x.Ax == -5)
            {
                this.transform.localScale = new Vector3(1.26f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 141f);
            }
            else if (x.Ax == 0)
            {
                this.transform.localScale = new Vector3(.8f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            }
        }
        else if (y.Ay == 5)
        {
            this.transform.localScale = new Vector3(1f, 1f);

            if (x.Ax == 1)
            {
                this.transform.localScale = new Vector3(1.0f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 79f);
            }
            else if (x.Ax == 2)
            {
                this.transform.localScale = new Vector3(1.07f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 69f);
            }
            else if (x.Ax == 3)
            {
                this.transform.localScale = new Vector3(1.15f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 60f);
            }
            else if (x.Ax == 4)
            {
                this.transform.localScale = new Vector3(1.26f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 51.5f);
            }
            else if (x.Ax == 5)
            {
                this.transform.localScale = new Vector3(1.39f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 45f);
            }
            else if (x.Ax == 0)
            {
                this.transform.localScale = new Vector3(1f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            }


            if (x.Ax == -1)
            {
                this.transform.localScale = new Vector3(1.0f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 101f);
            }
            else if (x.Ax == -2)
            {
                this.transform.localScale = new Vector3(1.07f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 111f);
            }
            else if (x.Ax == -3)
            {
                this.transform.localScale = new Vector3(1.15f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 120f);
            }
            else if (x.Ax == -4)
            {
                this.transform.localScale = new Vector3(1.26f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 128.5f);
            }
            else if (x.Ax == -5)
            {
                this.transform.localScale = new Vector3(1.39f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 135f);
            }
            else if (x.Ax == 0)
            {
                this.transform.localScale = new Vector3(1f, 1f);
                this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            }

        }
    }
}
