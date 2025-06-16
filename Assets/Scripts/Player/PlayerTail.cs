using System.Collections.Generic;
using UnityEngine;

public class PlayerTail : MonoBehaviour
{
    public static PlayerTail Instance;

    [SerializeField] Transform[] tennisBallPositions;
    List<GameObject> tennisBalls = new List<GameObject>();
    int tennisBallAmount;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    private void Start()
    {
        GameController.Instance.onGameStart += ResetTail;
    }
    public void AddTennisBall(GameObject _tennisBall)
    {
        _tennisBall.transform.parent = tennisBallPositions[tennisBallAmount];
        _tennisBall.transform.position = tennisBallPositions[tennisBallAmount].position;
        tennisBallAmount++;
        tennisBalls.Add(_tennisBall);
    }

    void ResetTail()
    {
        tennisBallAmount = 0;
        for (int i = 0; i < tennisBalls.Count; i++)
        {
            Destroy(tennisBalls[i]);
        }
        tennisBalls.Clear();
    }
}//Class
