using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenu : MonoBehaviour
{
    [SerializeField] GameObject platformPrefab;
    [SerializeField] GameObject jumpPadPrefab;

    public void SpawnPlatform()
    {
        Instantiate(platformPrefab, new Vector2(0f, 0f), Quaternion.identity);
    }
    public void JumpPadPlatform()
    {
        Instantiate(jumpPadPrefab, new Vector2(0f, 0f), Quaternion.identity);
    }
}