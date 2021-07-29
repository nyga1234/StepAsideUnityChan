using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    //CarPrefab
    public GameObject carPrefab;

    //CoinPrefab
    public GameObject coinPrefab;

    //TrafficConePrefab
    public GameObject TrafficConePrefab;

    //Unityちゃんとオブジェクトの距離
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

        //Unityちゃんとオブジェクトの距離を求める
        this.difference = this.unitychan.transform.position.z - this.transform.position.z;

        
    }

    // Update is called once per frame
    void Update()
    {   
        // 画面外に出たら破棄する
        if (this.difference > 1)
        {
            Destroy(gameObject);
        }
    }
}
