using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour
{
    //�A�j���[�V�������邽�߂̃R���|�[�l���g������
    private Animator myAnimator;
    //Unity�������ړ�������R���|�[�l���g������
    private Rigidbody myRigidbody;
    //�O�����̑��x
    private float velocityZ = 16f;
    //�������̑��x
    private float velocityX = 10f;
    //���E�̈ړ��ł���͈�
    private float movableRange = 3.4f;

    // Start is called before the first frame update
    void Start()
    {
        //Animator�R���|�[�l���g���擾
        this.myAnimator = GetComponent<Animator>();

        //����A�j���[�V�������J�n
        this.myAnimator.SetFloat("Speed", 1);

        //Rigidbody�R���|�[�l���g���擾
        this.myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //�������̓��͂ɂ�鑬�x
        float inputVelocityX = 0;

        //Unity��������L�[�܂��̓{�^���ɉ����č��E�Ɉړ�������
        //Unity�����ɑ��x��^����
        this.myRigidbody.velocity = new Vector3(0, 0, this.velocityZ);       
    }
}
