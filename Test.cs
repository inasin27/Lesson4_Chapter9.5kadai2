using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; //�̗�
    private int power = 25; //�U����
    private int mp = 53; //���@��

    //�U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    //�h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        //�c��hp�����炷
        this.hp -= damage;
    }

    //���@�p�̊֐�
    public void Magic(int magical)
    {
        //�c��MP�����炷
        this.mp -= magical;
        Debug.Log("���@�U���������B�c��MP��" + mp);
    }
}
public class Test : MonoBehaviour
{

    void Start()
    {
        //Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss Lastboss = new Boss();
        //�U���p�̊֐����Ăяo��
        Lastboss.Attack();
        //�h��p�̊֐����Ăяo��
        Lastboss.Defence(10);

        int mp2; mp2 = 53;
        //�֐���10��Ăяo��
        for (int c = 0; c < 11; c++)
        {
            if ( mp2 < 5)
            {
                Debug.Log("MP������Ȃ����߁A���@���g���Ȃ�");
            }
            else
            {
                //���@�p�̊֐����Ăяo��
                Lastboss.Magic(5);

                mp2 = mp2 - 5;
            }
        }
    }

    void Update()
    {
        
    }
}

