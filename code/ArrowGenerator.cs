using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;

    float span = 1.0f;
    float delta = 0;

    void Update(){
        this.delta += Time.deltaTime; // 每0.016秒
        if(this.delta > this.span){   // 1秒就歸0並產出箭頭
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject; // 利用Instantiate製作
            int px = Random.Range(-6,7); // 隨機指定位置
            go.transform.position = new Vector3(px,7,6);
        }
    }

}
