using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemGenerator : MonoBehaviour
{
    //carPrefabを入れる
    public GameObject carPrefab;
    //coinPrefabを入れる
    public GameObject coinPrefab;
    //cornPrefabを入れる
    public GameObject conePrefab;
    //スタート地点
    private int startPos = 80;
    //ゴール地点
    private int goalPos = 360;
    //アイテムを出すx方向の範囲
    private float posRange = 3.4f;
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //UnityちゃんのZ座標
    private float UnityChanPosZ = 0.0f;
    //Unityちゃんとコーンの距離
    private float differenceCone;
    //Unityちゃんとコインの距離
    private float differenceCoin;
    //Unityちゃんと車の距離
    private float differenceCar;




    // Start is called before the first frame update
    void Start()
    {

        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //Unityちゃんとコーンの位置の差を求める
        this.differenceCone = this.unitychan.transform.position.z - this.conePrefab.transform.position.z;
        //Unityちゃんとコインの位置の差を求める
        this.differenceCoin = this.unitychan.transform.position.z - this.conePrefab.transform.position.z;
        //Unityちゃんと車の位置の差を求める
        this.differenceCar = this.unitychan.transform.position.z - this.conePrefab.transform.position.z;
    }
    

    // Update is called once per frame
    void Update()
    {
        //UnityちゃんのZ座標の位置
        //this.UnityChanPosZ = this.unitychan.transform.position.z;


        for (float UnityChanPosZ= 0; UnityChanPosZ < 360; UnityChanPosZ += 15)
        {
            if (UnityChanPosZ + 15 < this.unitychan.transform.position.z)
            {
                //UnityちゃんのZ座標の位置を保存
                this.UnityChanPosZ = this.unitychan.transform.position.z;
                Debug.Log(UnityChanPosZ);

                //どのアイテムを出すのかをランダムに設定
                int num = Random.Range(1, 11);
                if (num <= 2)
                {
                    //コーンをx軸方向に一直線に生成
                    for (float j = -1; j <= 1; j += 0.4f)
                    {
                        GameObject cone = Instantiate(conePrefab);
                        cone.transform.position = new Vector3(4 * j, cone.transform.position.y, UnityChanPosZ);
                    }
                }
                else
                {

                    //レーンごとにアイテムを生成
                    for (int j = -1; j <= 1; j++)
                    {
                        //アイテムの種類を決める
                        int item = Random.Range(1, 11);
                        //アイテムを置くZ座標のオフセットをランダムに設定
                        int offsetZ = Random.Range(-5, 6);
                        //60%コイン配置:30%車配置:10%何もなし
                        if (1 <= item && item <= 6)
                        {
                            //コインを生成
                            GameObject coin = Instantiate(coinPrefab);
                            coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, UnityChanPosZ);
                        }
                        else if (7 <= item && item <= 9)
                        {
                            //車を生成
                            GameObject car = Instantiate(carPrefab);
                            car.transform.position = new Vector3(posRange * j, car.transform.position.y, UnityChanPosZ + offsetZ);
                        }
                    }
                }


            }
        }
 
    }
}
