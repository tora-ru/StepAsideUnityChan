using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{
    public Transform player;

    float distance;

    private void Start()
    {
        distance = player.position.z - transform.position.z;
    }

    //トリガーモードでオブジェクトと接触した場合の処理
    private void OnTriggerEnter(Collider other)
    {
        
        //オブジェクトに衝突した場合
        if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag" || other.gameObject.tag == "CoinTag")
        {
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        var newpos = transform.position;
        newpos.z = player.position.z - distance;
        transform.position = newpos;
    }
}
