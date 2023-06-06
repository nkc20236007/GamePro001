using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public GameObject MyShot_0;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-0.05f, 0, 0);
            this.animator.SetBool("LeftBool",true);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            this.animator.SetBool("LeftBool", false);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0.05f, 0, 0);
            this.animator.SetBool("RightBool", true);

        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            this.animator.SetBool("RightBool", false);

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0, 0.05f, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(0, -0.05f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject shot = GameObject.Find("shotGenerator");
            shot.GetComponent<shotGenerator>().Blust();
        }
     }
 }
