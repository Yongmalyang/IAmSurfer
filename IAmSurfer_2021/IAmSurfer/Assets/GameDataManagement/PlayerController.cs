using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class PlayerController : MonoBehaviour
{

    static GameObject _container;
    static GameObject Container
    {
        get
        {
            return _container;
        }
    }

    static PlayerController _instance;
    public static PlayerController Instance                                                   //해당 스크립트를 어디에서든 불러올 수 있게끔 하는 함수 
    {
        get
        {
            if (!_instance)
            {
                _container = new GameObject();
                _container.name = "PlayerController";
                _instance = _container.AddComponent(typeof(PlayerController)) as PlayerController;
                DontDestroyOnLoad(_container);
            }
            return _instance;
        }
    }

    public PlayerData _gameData;
    public PlayerData playerData
    {
        get
        {
            if (_gameData == null)
            {

                LoadGameData();
                //UnityEngine.Debug.Log("데이터 널");
                ToGameJson();
            }
            return _gameData;
        }
    }

    public void LoadGameData()                                                                                                                  //게임 데이터 불러오기
    {
        string filePath = Path.Combine(Application.dataPath, "GameDataManagement/playerData.json");


        if (File.Exists(filePath))
        {
            print(filePath);
            //UnityEngine.Debug.Log("불러오기 성공!");
            string FromJsonData = File.ReadAllText(filePath);
            _gameData = JsonUtility.FromJson<PlayerData>(FromJsonData);
        }
        else
        {
            //UnityEngine.Debug.Log("새 파일 생성!");
            // _gameData = new SatelliteGameData();
            ToGameJson();

        }
    }
    System.IO.StreamWriter SW = null;


    [ContextMenu("To Game Json")]
    public void ToGameJson()
    {
        string jsonData = JsonUtility.ToJson(playerData);
        string path = Path.Combine(Application.dataPath, "GameDataManagement/playerData.json");
        File.WriteAllText(path, jsonData);
        //File.WriteAllText(Application.persistentDataPath + "/GameJson.json", JsonUtility.ToJson(gameData, true));
    }

    void OnApplicationQuit()
    {
        ToGameJson();
        //UnityEngine.Debug.Log("저장완료했음");
    }

    void Start()
    {
        //Debug.Log("폴스면 최초실행" + PlayerPrefs.HasKey("playnumber"));
        if (PlayerPrefs.HasKey("key") == true)
        {
            if (gameObject.name == "DataControllerF")
                GameObject.Find("DataControllerF").SetActive(false);
        }

        if (PlayerPrefs.HasKey("key") == false) // 최초실행이면
        {
            PlayerPrefs.SetInt("key", PlayerPrefs.GetInt("key", 0)); //최초실행시 여기 저장...
            //Debug.Log("최초실행");

            ToGameJson(); 

            if (gameObject.name == "DataControllerF")
                GameObject.Find("DataControllerF").SetActive(false);
        }


    }

    IEnumerator SaveGameData()
    {
        while (true)
        {
            string path = Path.Combine(Application.dataPath, "GameDataManagement/playerData.json");
            File.WriteAllText(path, JsonUtility.ToJson(playerData));
            //UnityEngine.Debug.Log("코루틴 게임데이터 저장");
            try
            {
                SW = new System.IO.StreamWriter(path);
            }
            catch (Exception exp)
            {
                UnityEngine.Debug.Log(exp);
            }
            finally
            {
                if (SW != null)
                {
                    SW.Close();
                }
            }



            yield return new WaitForSeconds(0.5f);
        }

    }

    [System.Serializable]
    public class PlayerData
    {
        public int lives = 3;
        public int score = 0;
        public int money = 0;
        public int best_score = 0;
        public bool sound = true;
        public bool game_over = false;
    }
}
