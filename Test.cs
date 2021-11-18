using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; //体力
    private int power = 25; //攻撃力
    private int mp = 53; //魔法力

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }

    //魔法用の関数
    public void Magic(int magical)
    {
        //残りMPを減らす
        this.mp -= magical;
        Debug.Log("魔法攻撃をした。残りMPは" + mp);
    }
}
public class Test : MonoBehaviour
{

    void Start()
    {
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss Lastboss = new Boss();
        //攻撃用の関数を呼び出す
        Lastboss.Attack();
        //防御用の関数を呼び出す
        Lastboss.Defence(10);

        int mp2; mp2 = 53;
        //関数を10回呼び出す
        for (int c = 0; c < 11; c++)
        {
            if ( mp2 < 5)
            {
                Debug.Log("MPがたりないため、魔法が使えない");
            }
            else
            {
                //魔法用の関数を呼び出す
                Lastboss.Magic(5);

                mp2 = mp2 - 5;
            }
        }
    }

    void Update()
    {
        
    }
}

