using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

// C:/Users/HOME/Desktop/My/Assets




public  class FileManager :MonoBehaviour
{
    public static T[] FromJson<T>(string json)
    {

        Wrapper<T> array = JsonUtility.FromJson<Wrapper<T>>(json);

        return array.mArray;
    }
    public static void JsonFileSave<T>(string path, List<T> List)
    {
        //경로 및 파일 이름 설정
        string filePath = Path.Combine(Application.dataPath, "Save FIle", path + ".json");

        //리스트를 배열로 변경
        Wrapper<T> TempArray = new Wrapper<T>();
        TempArray.mArray = List.ToArray();

        //변경된 리스트 배열을 Json 파일로 생성
        string JsonString = JsonUtility.ToJson(TempArray,true);
        File.WriteAllText(filePath, JsonString);


    }

    public static List<T> JsonFileLoad<T>(string path)
    {
        try
        {
            //경로 및 파일 이름 설정
            string filePath = Path.Combine(Application.dataPath, "Save FIle", path + ".json");

            //스트링으로 된 Json파일 받아오기
            string JsonString = File.ReadAllText(filePath);


            //배열로 변경

            var Data = FromJson<T>(JsonString);

            List<T> returnList = new List<T>();
            foreach (T temp in Data)
            {
                returnList.Add(temp);
            }

            return returnList;
        }
        catch (System.Exception e)
        {
            if (e is DirectoryNotFoundException)
            {
                print("파일 경로가 유효하지 않습니다.");
                print(e);
                return null;
            }
            else if (e is FileNotFoundException)
            {
                print("파일을 찾을 수 없습니다.");
                print(e);
                return null;

            }
            else
            {
                print(e.Message);
                return null;
            }
        }
    }


    [System.Serializable]
    public class Wrapper<T>
    {
        public T[] mArray;
    }







    private void SetDirectoryPath()
    {
        Directory.CreateDirectory(Application.dataPath + "/Save File/User Data");
        Directory.CreateDirectory(Application.dataPath + "/Save File/Resources Data");
    }


    //[ContextMenu("Json File Save")]
    //public  void JsonFileSave(/*string path, string FileName,*/ List<Mercenary> obj)
    //{


    //    tempArray = obj.ToArray();
    //   print( JsonUtility.ToJson(tempArray));
    //    //Path.Combine(Application.dataPath, "Save File", path, FileName + ".json");

    //    //string filePath = Path.Combine(Application.dataPath + "/.json");



    //    //File.WriteAllText(filePath, JsonUtility.ToJson(obj.ToArray()));
    //}

    ////public bool TryJsonFileLoad(string path,string FileName)
    ////{
    ////   

    ////    string str = JsonUtility.ToJson(new Mercenary("용병 1 ", 10, 20, 50, 30, Mercenary.EGrade.Probie));

    ////    return true;

    ////  //  var data =  JsonUtility.FromJson(str);
    ////}

}
