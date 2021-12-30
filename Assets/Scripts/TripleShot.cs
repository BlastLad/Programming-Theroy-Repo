using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShot : Enemy
{
    // INHERITANCE 
    [SerializeField]
    int NumberToFire = 3;
    float change = 0;
    Vector3 ogPosition;
    private void Awake()
    {
        ogPosition = firePoint.position;

    }

    // POLYMORPHISM
    public override void Fire()
    {
        for (int i = 0; i < NumberToFire; i++)
        {            
            
            change += 1;
            firePoint.position += new Vector3(0, 0, change);
            base.Fire();
            firePoint.position -= new Vector3(0, 0, change);
        }
        
        change = 0;
    }
}
