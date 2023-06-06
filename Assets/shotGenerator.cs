using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotGenerator : MonoBehaviour
{
    public GameObject MyChar_0;
    public GameObject MyShot_0;
    GameObject zahyo;

    // Start is called before the first frame update
    private void Update()
    {
        GameObject zahyo = GameObject.Find("MyChar_0");
    }
    // Update is called once per frame
    public void Blust()
    {
        GameObject go = Instantiate(MyShot_0);
        go.transform.position = new Vector3(0, 0, 0);
    }
}

