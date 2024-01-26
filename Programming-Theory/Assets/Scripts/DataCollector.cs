using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class DataCollector : MonoBehaviour
{
    public string nameStar
    {
        get; private set;
    }

    public Color colorStar { get; private set; }

    private int m_massStar;
    public int massStar//Encapsulation
    {
        get
        {
            return m_massStar;
        }
        private set
        {
            if (value <= 0)
            {
                Debug.LogError("You cant set Star mass to negative number or zero.");
            }
            else { m_massStar = value; }
        }
    }

    public string namePlanet
    {
        get; private set;
    }

    public Color colorPlanet { get; private set; }

    private int m_massPlanet;
    public int massPlanet//Encapsulation
    {
        get
        {
            return m_massPlanet;
        }
        private set
        {
            if (value <= 0)
            {
                Debug.LogError("You cant set Star mass to negative number or zero.");
            }
            else { m_massPlanet = value; }
        }
    }


    [SerializeField] private TMP_InputField[] nameInput = new TMP_InputField[2];
    [SerializeField] private TMP_InputField[] massInput = new TMP_InputField[2];
    [SerializeField] private TMP_Dropdown[] ColorSelection = new TMP_Dropdown[2];
    public void StartButton()
    {
        

        nameStar = nameInput[0].text;
        colorStar = ColorDef(ColorSelection[0].value);
        massStar = int.Parse(massInput[0].text);

        namePlanet = nameInput[1].text;
        colorPlanet = ColorDef(ColorSelection[1].value);
        massPlanet = int.Parse(massInput[1].text);

        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("SampleScene");
        
    }


    private Color ColorDef(int index)
    {
        if(index == 0)
        {
            return Color.red;
        }
        else if(index == 1)
        {
            return Color.green;
        }
        else if (index == 2)
        {
            return Color.blue;
        }
        else if (index == 3)
        {
            return Color.yellow;
        }else if(index == 4)
        {
            return Color.white;
        }
        else
        {
            return Color.black;
        }
    }
}
