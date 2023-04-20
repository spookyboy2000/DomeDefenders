using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PickUpItems : MonoBehaviour
{
    [SerializeField]
    private TMP_Text TitaniumCounter, AluminiumCounter, ScrapCounter, DiamondCounter;

    private int TitaniumAmount, AluminiumAmount, ScrapAmount, DiamondAmount;
    // Start is called before the first frame update
    void Start()
    {
        TitaniumAmount = 0;
        AluminiumAmount = 0;
        ScrapAmount = 0;
        DiamondAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TitaniumCounter.text = TitaniumAmount + "      Titanium";
        AluminiumCounter.text = AluminiumAmount + "      Aluminium";
        ScrapCounter.text = ScrapAmount+ "      Scrap";
        DiamondCounter.text = DiamondAmount + "      Diamond";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.GetComponent<ItemScript>().itemType == ItemTypes.Titanium)
        {
            TitaniumAmount += 1;
            Destroy(collision.gameObject);
        }
        else if (collision.GetComponent<ItemScript>().itemType == ItemTypes.Aluminium)
        {
            AluminiumAmount += 1;
            Destroy(collision.gameObject);
        }
        else if (collision.GetComponent<ItemScript>().itemType == ItemTypes.Scrap)
        {
            ScrapAmount += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<ItemScript>().itemType == ItemTypes.Diamond)
        {
            DiamondAmount += 1;
            Destroy(collision.gameObject);
        }
    }
}
