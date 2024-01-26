using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Star : AObj //INHERITANCE
{
    [SerializeField] private GameObject planeObj;
    [SerializeField] private float speed;
    [SerializeField] private TMP_Text nameText, massText;
    [SerializeField] private Material material;
    private DataCollector collector;

    private void Start()
    {
        collector = GameObject.FindAnyObjectByType<DataCollector>().GetComponent<DataCollector>();
        ChangeColor(material, collector.colorStar);
        gameObject.name = collector.namePlanet;
        SetYcoordinate(gameObject, collector.massStar, collector.massPlanet);
        nameText.SetText("Star name : "+gameObject.name);
        massText.SetText("Star mass : " + collector.massStar.ToString());

        gameObject.GetComponent<Rigidbody>().mass = collector.massStar;
    }
    private void Update()
    {
        Move(gameObject, planeObj, collector.massPlanet);
        Pulling(gameObject, planeObj, collector.massStar, collector.massPlanet);
    }
}
