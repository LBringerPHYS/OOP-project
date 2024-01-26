using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AObj : MonoBehaviour
{
    public void Move(Vector3 Aobjpos,GameObject obj, float speed)
    {
        obj.GetComponent<Rigidbody>().velocity = Vector3.Cross(obj.transform.position,Aobjpos).normalized * speed;
    }

    public void Pulling(GameObject obj, GameObject pullingobj, float mass1, float mass2)
    {
        Vector3 distance = (obj.transform.position - pullingobj.transform.position);
        obj.GetComponent<Rigidbody>().AddForce(distance.normalized * mass1 * mass2 / Mathf.Pow((distance).magnitude,2), ForceMode.Force);
    }

    public void SetYcoordinate(GameObject obj, float mass1,float mass2)
    {
        obj.transform.position = new Vector3(obj.transform.position.x,mass1/(mass1+mass2), obj.transform.position.z);
    }
}
