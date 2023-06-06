using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("MyChar_0");
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(-0.1f, 0, 0);

        if (transform.position.y < -5.0f) 
        {
            Destroy(gameObject);
        }

        // �A�^������
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.3f;
        float r2 = 0.2f;

        if(d < r1 + r2)
        {
            // �ēX�N���v�g�Ƀv���C���[�ƏՓ˂������Ƃ�`����
            GameObject Director = GameObject.Find("GameDirector");
            Director.GetComponent<GameDirector>().DecreaseTime();

            // �Փ˂����ꍇ�͒P�������
            Destroy(gameObject);
        }
    }
}
