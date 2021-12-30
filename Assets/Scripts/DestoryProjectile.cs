using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryProjectile : MonoBehaviour
{

    private void Awake()
    {
        StartCoroutine(destroyDelay());
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private IEnumerator destroyDelay()
    {
        yield return new WaitForSeconds(6f);
        Destroy(gameObject);
    }

  
}
