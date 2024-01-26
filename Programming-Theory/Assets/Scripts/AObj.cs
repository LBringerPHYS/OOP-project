using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AObj : MonoBehaviour //INHERITANCE parent
{
    public void Move(GameObject obj,GameObject otherobj, float mass2)
    {
        Vector3 distance = (obj.transform.position - otherobj.transform.position);
        obj.GetComponent<Rigidbody>().velocity = Vector3.Cross(obj.transform.position,otherobj.transform.position).normalized * (mass2/Mathf.Pow(distance.magnitude,2));
    }

    public void Pulling(GameObject obj, GameObject pullingobj, float mass1, float mass2)
    {
        Vector3 distance = (pullingobj.transform.position - obj.transform.position);
        obj.GetComponent<Rigidbody>().AddForce(distance.normalized * mass1 * mass2 / Mathf.Pow((distance).magnitude,2), ForceMode.Force);
    }

    public void SetYcoordinate(GameObject obj, float mass1,float mass2)
    {
        obj.transform.position = new Vector3(obj.transform.position.x,mass1/(mass1+mass2), obj.transform.position.z);
    }

    public virtual void ChangeColor(Material goMaterial, Color assignedColor)
    {
        goMaterial.color = assignedColor;
    }
}
