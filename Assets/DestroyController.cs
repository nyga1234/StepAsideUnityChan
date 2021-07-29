using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour
{
    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;

    //CarPrefab
    public GameObject carPrefab;

    //CoinPrefab
    public GameObject coinPrefab;

    //TrafficConePrefab
    public GameObject TrafficConePrefab;

    //Unity�����ƃI�u�W�F�N�g�̋���
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
        
    }

    // Update is called once per frame
    void Update()
    {

        //Unity�����ƃI�u�W�F�N�g�̋��������߂�
        this.difference = this.unitychan.transform.position.z - this.transform.position.z;

        // ��ʊO�ɏo����j������
        if (this.difference > 5)
        {
            Destroy(gameObject);
        }
    }
}
