using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour{

    GameObject player;
    void Start(){
        this.player = GameObject.Find("player");
    }
    void Update(){
        // 每個影格等速往下移動
        transform.Translate(0,-0.06f,0);

        // 當箭頭超出遊戲畫面捨棄物件
        if(transform.position.y < -5.0f){
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir =  p1 - p2;

        float d = dir.magnitude;
        float r1 = 0.5f; // 箭頭的圓半徑
        float r2 = 1.0f; // 遊戲角色的圓半徑

        if(d < r1 + r2){

            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
            // 發生衝突時就捨棄箭頭
            Destroy(gameObject);
        }



    }
}