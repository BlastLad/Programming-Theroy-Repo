using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField]
    protected float speed = 3;
    [SerializeField]
    protected float fireSpeed = 4;
    [SerializeField]
    protected GameObject projectile;
    [SerializeField]
    protected Transform firePoint;
    // Start is called before the first frame update
    bool moveDown = true;
    void Start()
    {
        StartCoroutine(CoolDown(fireSpeed));
    }

    // Update is called once per frame
    void Update()
    {
        if (moveDown)
        {
            MoveDown();
        }
        else
        {
            MoveUP();
        }
    }

    public virtual void Fire()//will use a for loop and base.fire
    {
        GameObject firedProjectile = Instantiate(projectile, firePoint.position, Quaternion.identity);
        firedProjectile.GetComponent<Rigidbody>().AddForce(-firePoint.right * speed * 2, ForceMode.Impulse);
    }

    private IEnumerator CoolDown(float waitForSeconds)
    {
        yield return new WaitForSeconds(waitForSeconds);
        Fire();
        StartCoroutine(CoolDown(fireSpeed));
    }

    public virtual void MoveUP()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.z > -3.91f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -3.91f);
            moveDown = true;
        }
    }

    public virtual void MoveDown()
    {
        transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        if (transform.position.z < -15.43f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -15.43f);
            moveDown = false;
        }
    }
}
