using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
public class Mercenary : MonoBehaviour
{
    public enum EGrade
    {
        Probie, //견습
        Expert, //숙련
        Hero,   //영웅
        Legend, //전설
        Elder   //장로
    }
    public string Name;
    public int Damage;
    public int Price;
    public int HP;
    public int MP;
    public EGrade Grade;
    public GameObject Modeling;
  
    
}
