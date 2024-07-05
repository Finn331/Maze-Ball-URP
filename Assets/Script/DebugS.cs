using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugS : MonoBehaviour
{
    //[SerializeField]
    //private GameObject _square;
    public GameObject cubePrefab;
    
    private void Awake()
    {
        Debug.Log("Awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(_square.transform.position);
        //Debug.Log(_square.transform.rotation);
        //Debug.Log(_square.transform.localScale);

        //Vector3 newPos = new Vector3(5, 0, 0);
        //_square.transform.position = newPos;

        RangeInt range = new RangeInt(1, 50);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");
        float randomValue = Random.Range(0.0f, 35f);
        RangeInt random = new RangeInt(1, 50);
        Vector2 randomPos = new Vector2(randomValue, randomValue);
        Instantiate(cubePrefab, randomPos, Quaternion.identity);
    }

    //private void OnEnable()
    //{
    //    Debug.Log("OnEnable");
    //}

    //private void OnDisable()
    //{
    //    Debug.Log("OnDisable");
    //}

    //private void OnDestroy()
    //{
    //    Debug.Log("OnDestroy");
    //}

    //private void LateUpdate()
    //{
    //    Debug.Log("LateUpdate");
    //}

    //private void OnApplicationQuit()
    //{
    //    Debug.Log("On Application Quit");
    //}

    void InstantiateCube()
    {
        
        
    }
}
