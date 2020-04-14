using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public  int Gold = 500;


    public List<Mercenary> MercenaryList = new List<Mercenary>();
    public List<Mercenary> ShopList = new List<Mercenary>();

    void Start()
    {
       //FileManager.JsonFileSave("User", MercenaryList);

        ResourcesFileLoad();

        
    }

    void Update()
    {
        print(Gold);
    }

    public void ResourcesFileLoad()
    {
        //용병정보 가져오기
        MercenaryList = FileManager.JsonFileLoad<Mercenary>("User");
       

    }

    public int RendomMercenary()
    {
        print(MercenaryList.Count);
        return Random.Range(0, MercenaryList.Count);
        
    }
}
