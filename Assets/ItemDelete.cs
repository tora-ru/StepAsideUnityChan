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

    //�g���K�[���[�h�ŃI�u�W�F�N�g�ƐڐG�����ꍇ�̏���
    private void OnTriggerEnter(Collider other)
    {
        
        //�I�u�W�F�N�g�ɏՓ˂����ꍇ
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
