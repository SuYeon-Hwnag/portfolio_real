using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public string enermy_name;
    public int Hp_Max;
    public int Hp_Now;
    public int attacked_damage;

    public float collision_radius = 10.0f; // 충돌범위

    private void SetEnermy(string _enermy_name, int _Hp_Max, int _Hp_Now, int _attacked_damage)
    {
        enermy_name = _enermy_name;
        Hp_Max = _Hp_Max;
        Hp_Now = _Hp_Now;
        attacked_damage = _attacked_damage;
    }


    void Start()
    {
        if(GameObject.FindGameObjectWithTag("Level1"))
        {
            SetEnermy("Level1", 100, 100, 50);
        }
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Hp_Now -= attacked_damage;
            Debug.Log(Hp_Now + "가 몬스터 현 체력임");
            if(Hp_Now<=0)
            {
                Destroy(gameObject);
            }
        }
    }
}
