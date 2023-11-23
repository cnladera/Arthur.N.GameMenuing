using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class clicky : MonoBehaviour
{
    public TextMeshProUGUI cCount;
    public TextMeshProUGUI hCount;
    public TextMeshProUGUI sCount;
    public TextMeshProUGUI mCount;
    public TextMeshProUGUI studentLoans;
    public TextMeshProUGUI studentLoansv2;
    private int lvlTwoLizzo = 1;
    private float Ccountee = 0;
    private int Hcountee = 0;
    private int Scountee = 0;
    private int Mcountee = 0;
    // Start is called before the first frame update
    void Start()
    {
        studentLoans.text = "50";
        studentLoansv2.text = "50";
    }

    // Update is called once per frame
    void Update()
    {
        int temp = (int)Ccountee;
        cCount.text = temp.ToString();

        hCount.text = Hcountee.ToString();
        sCount.text = Scountee.ToString();
        mCount.text = Mcountee.ToString();
        Ccountee += (Time.deltaTime) * Hcountee * lvlTwoLizzo;
    }
    
    public void plus1Crystal()
    {
        Ccountee += Scountee + 1;
        
    }

    public void plus1Cook()
    {
        int Price = 50 + Hcountee * Hcountee * 20;

        if (Price > Ccountee)
        {
            return;
        }
        Hcountee += 1;
        Ccountee -= Price;
        Price = 50 + Hcountee * Hcountee * 20;
        studentLoansv2.text = Price.ToString();
    }

    public void minus1year()
    {
        int Price = 100 + Mcountee * Mcountee * 60;

        if (Price > Ccountee)
        {
            return;
        }
        Mcountee += 1;
        Ccountee -= Price;

        lvlTwoLizzo += 1;


    }

    public void plus1RyanReynolds()
    {
        int Price = 50 + Scountee * Scountee * 20;
        
        if(Price > Ccountee)
        {
            return;
        }
        Scountee += 1;
        Ccountee -= Price;
        Price = 50 + Scountee * Scountee * 20;
        studentLoans.text = Price.ToString();

    }

}


