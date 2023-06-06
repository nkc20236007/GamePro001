using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy_0;
    float span = 0.05f;
    float delta = 0;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(Enemy_0);
            int px = Random.Range(-7, 7);
            go.transform.position = new Vector3(9.5f, px, 0);
        }
    }
}
