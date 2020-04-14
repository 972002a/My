using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    Manager manager;

 

    void Start()
    {
        manager = GameObject.Find("Game Manager").GetComponent<Manager>();
        ShopInit();
    }


    void Update()
    {
       
    }

    private void ShopInit()
    {

         manager.ShopList.Add(manager.MercenaryList[manager.RendomMercenary()]);
        
       
    }
   

    public void BuyMercenary()
    {
        
        GetComponent<Image>().sprite = null;
        
    }
}
