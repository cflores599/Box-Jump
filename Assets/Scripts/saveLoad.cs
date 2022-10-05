using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class saveLoad : MonoBehaviour
{
    // Start is called before the first frame update
    private string record;
    private const string fileName = "recordData.data";
    private RecordInfo recordInfo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Save(float newRecord)
    {
        recordInfo = new RecordInfo(newRecord);
        record = JsonUtility.ToJson(recordInfo);
        Debug.Log(record);
        string path = Path.Combine(Application.persistentDataPath, fileName);
        File.WriteAllText(path, record);
        Debug.Log(path);

    }
    public float Load()
    {
        string path = Path.Combine(Application.persistentDataPath, fileName);
        string recordInfojson = File.ReadAllText(path);
        RecordInfo recordInfoLoad = JsonUtility.FromJson<RecordInfo>(recordInfojson);
        Debug.Log(recordInfoLoad.record);
        return recordInfoLoad.record;

    }
}
