using System;
using Unity.VisualScripting;
using UnityEngine;

public class Pellet : MonoBehaviour
{
    [SerializeField] SphereCollider sphereCollider;
    [SerializeField] MeshRenderer mr;
    [SerializeField] Color basketball;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sphereCollider.enabled = false;
            mr.material.color = basketball;
            PelletCollector.Instance.PelletCollected();
            PlayerTail.Instance.AddTennisBall(gameObject);
        }
    }
}//Class
