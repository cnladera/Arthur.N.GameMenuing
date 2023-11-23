using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HTPmain : MonoBehaviour
{
    public GameObject first;

    public void Main(bool b)
    {
        first.SetActive(b);
        
    }

    public GameObject dfsg;
    public GameObject linglong;

    public void bingbong(bool b)
    {
        dfsg.SetActive(b);
        linglong.SetActive(false);

    }
}
