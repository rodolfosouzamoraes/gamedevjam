using System.Collections.Generic;
using UnityEngine;

public class BossShooting : MonoBehaviour
{
    private int index = 0;
    private List<GameObject> stones = new List<GameObject>();
    [SerializeField] private int stonesAmount = 5;
    [SerializeField] private GameObject[] stonesPrefab;
    [SerializeField] private Transform aim;

    private void Awake()
    {
        InstantiateStones();
    }

    private void InstantiateStones()
    {
        for (int i = 0; i < stonesAmount; i++)
        {
            GameObject stone = Instantiate(stonesPrefab[i % stonesPrefab.Length], aim.position, aim.localRotation);
            stone.SetActive(false);
            stones.Add(stone);
        }
    }

    public void Shoot()
    {
        GameObject stone = stones[index];
        
        if (!stone.activeSelf)
        {
            stone.SetActive(true);
            ReturnStoneToAim(stone.transform);
        }

        index++;
        index %= stones.Count;
    }

    public void ReturnStoneToAim(Transform stone)
    {
        stone.position = aim.position;
        stone.localRotation = aim.localRotation;
    }
}
