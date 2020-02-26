using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //current health
    [SerializeField] int cur = 5;

    public void doDamage(int n)
    {
        //subtract damage from current health
        cur -= n;

        //destroy if dead
        if (cur <= 5)
            Destroy(gameObject);
    }


}
