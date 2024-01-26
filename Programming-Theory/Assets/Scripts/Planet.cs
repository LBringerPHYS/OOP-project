using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Planet : AObj //INHERITANCE
{
    [SerializeField] private GameObject starObj;
    [SerializeField] private float speed;
    [SerializeField] private TMP_Text nameText, massText;
    [SerializeField] private Material material;
    private DataCollector collector;

    private void Start()
    {
        collector = GameObject.FindAnyObjectByType<DataCollector>().GetComponent<DataCollector>();
        ChangeColor(material, collector.colorPlanet);
        gameObject.name = collector.nameStar;
        SetYcoordinate(gameObject, collector.massPlanet, collector.massStar);
        nameText.SetText("Planet name : " + gameObject.name);
        massText.SetText("Planet mass : " + collector.massPlanet.ToString());

        gameObject.GetComponent<Rigidbody>().mass = collector.massPlanet;
    }
    private void Update()
    {
        Move(gameObject, starObj, collector.massStar);
        Pulling(gameObject, starObj, collector.massPlanet, collector.massStar);
    }

    public override void ChangeColor(Material goMaterial,Color assignedColor) // Polymorphism
    {
        goMaterial.color = assignedColor;
        goMaterial.SetFloat("_Metallic", collector.massPlanet / (collector.massStar + collector.massPlanet));
    }
}
