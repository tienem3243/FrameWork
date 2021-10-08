using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseInputController : MonoBehaviour
{
    public bool Up;
    public bool Down;
    public bool Right;
    public bool Left;
    public bool atk;

    public float vert;
    public float horzt;
    public bool shoundRespawn;
    public Vector3 TEMPVector3;
    public float moveSpeed;
    private void Update()
    {
        CheckInput();
        transform.position += new Vector3(horzt, vert, 0)*Time.deltaTime *moveSpeed;
    }
    public virtual void CheckInput()
    {
        horzt = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
    }
    public virtual float GetVertical()
    {
        return vert;
    }
    public virtual float GetHorizontal()
    {
        return horzt;
    }
    public virtual bool GetFire()
    {
        return atk;
    }
    public virtual bool GetRespawn()
    {
        return shoundRespawn;
    }
    public virtual Vector3 GetMovementDirectVector()
    {
        TEMPVector3 = Vector3.zero;
        if (Left || Right)
        {
            TEMPVector3.x = horzt;
        }
        if (Up || Down)
        {
            TEMPVector3.y = vert;
        }
        return TEMPVector3;
    }
}
