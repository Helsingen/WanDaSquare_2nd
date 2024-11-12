using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 生成战士 : MonoBehaviour
{

    public GameObject 战士模型;
    public GameObject 生成物体位置;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            float x = 生成物体位置.transform.position.x + Random.Range(-5f, 5f);
            float y = 生成物体位置.transform.position.y + Random.Range(-5f, 5f);
            GameObject 生成模型 = Instantiate(战士模型, new Vector3(x, y, 0), Quaternion.identity);
            
        }
    }
}
